const MAX_ITEMS = 50000;

function partition(arr, low, high) {
  const randomPivotIndex = low + Math.floor(Math.random() * (high - low + 1));
  [arr[randomPivotIndex], arr[high]] = [arr[high], arr[randomPivotIndex]];

  const pivot = arr[high];
  let i = low - 1;

  for (let j = low; j < high; j += 1) {
    if (arr[j] < pivot) {
      i += 1;
      [arr[i], arr[j]] = [arr[j], arr[i]];
    }
  }

  [arr[i + 1], arr[high]] = [arr[high], arr[i + 1]];
  return i + 1;
}

function validateNumberArray(arr) {
  if (!Array.isArray(arr)) {
    throw new TypeError("QuickSort expects an array of finite numbers.");
  }

  if (arr.some((value) => typeof value !== "number" || !Number.isFinite(value))) {
    throw new TypeError("QuickSort expects only finite numbers.");
  }
}

function processRange(sorted, stack, range) {
  if (!range) {
    return;
  }

  let [low, high] = range;

  while (low < high) {
    const pivotIndex = partition(sorted, low, high);
    const leftSize = pivotIndex - 1 - low;
    const rightSize = high - (pivotIndex + 1);

    // Process smaller side first and push the larger side to keep stack shallow.
    if (leftSize < rightSize) {
      if (pivotIndex + 1 < high) {
        stack.push([pivotIndex + 1, high]);
      }
      high = pivotIndex - 1;
    } else {
      if (low < pivotIndex - 1) {
        stack.push([low, pivotIndex - 1]);
      }
      low = pivotIndex + 1;
    }
  }
}

function quickSort(arr) {
  validateNumberArray(arr);

  if (arr.length <= 1) {
    return [...arr];
  }

  const sorted = [...arr];
  const stack = [[0, sorted.length - 1]];

  // Iterative QuickSort avoids call stack overflow on large inputs.
  while (stack.length > 0) {
    processRange(sorted, stack, stack.pop());
  }

  return sorted;
}

function parseInput(inputValue) {
  if (typeof inputValue !== "string") {
    throw new TypeError("Input must be text containing numbers.");
  }

  const normalized = inputValue.trim();
  if (!normalized) {
    throw new Error("Please enter at least one number.");
  }

  const tokens = normalized.split(/[\s,]+/).filter(Boolean);

  if (tokens.length > MAX_ITEMS) {
    throw new RangeError(`Too many numbers. Maximum allowed is ${MAX_ITEMS}.`);
  }

  return tokens.map((token) => {
    const parsed = Number(token);
    if (!Number.isFinite(parsed)) {
      throw new TypeError(`"${token}" is not a valid finite number.`);
    }
    return parsed;
  });
}

function isSortedAscending(arr) {
  for (let i = 1; i < arr.length; i += 1) {
    if (arr[i - 1] > arr[i]) {
      return false;
    }
  }
  return true;
}

const inputElement = document.getElementById("numbersInput");
const buttonElement = document.getElementById("sortBtn");
const statusElement = document.getElementById("status");
const resultElement = document.getElementById("result");

if (!inputElement || !buttonElement || !statusElement || !resultElement) {
  throw new Error("Required page elements are missing.");
}

buttonElement.addEventListener("click", () => {
  resultElement.classList.remove("error");

  try {
    const numbers = parseInput(inputElement.value);
    const sorted = quickSort(numbers);

    if (numbers.length === 1) {
      statusElement.textContent = "Single value detected. Already sorted.";
    } else if (isSortedAscending(numbers)) {
      statusElement.textContent = "Input was already sorted.";
    } else {
      statusElement.textContent = "Sorting complete.";
    }

    resultElement.textContent = sorted.join(", ");
  } catch (error) {
    if (error instanceof RangeError) {
      statusElement.textContent = "Input size error.";
    } else if (error instanceof TypeError) {
      statusElement.textContent = "Input format error.";
    } else {
      statusElement.textContent = "Input error.";
    }

    resultElement.textContent = error instanceof Error ? error.message : "Unknown error occurred.";
    resultElement.classList.add("error");
  }
});
