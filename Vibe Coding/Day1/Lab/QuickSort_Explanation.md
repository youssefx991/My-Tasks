# QuickSort Implementation Explanation

This document explains the QuickSort implementation in `QuickSort.cpp`, how it works, and its key components.

## 1. High-level idea

QuickSort is a **divide-and-conquer** sorting algorithm:

1. Choose a pivot element.
2. Partition the array so elements smaller than the pivot move left, and larger/equal elements move right.
3. Recursively apply the same process to the left and right subarrays.

In this implementation, the pivot is the **last element** (`arr[high]`), and partitioning uses the **Lomuto partition scheme**.

## 2. Key Components in `QuickSort.cpp`

## `partition(int arr[], int low, int high)`

Purpose:
- Rearrange the subarray `arr[low..high]` around `pivot = arr[high]`.
- Return the pivot's final index.

How it works:
- `i` tracks the boundary of elements known to be `< pivot`.
- `j` scans from `low` to `high - 1`.
- If `arr[j] < pivot`, increment `i` and swap `arr[i]` with `arr[j]`.
- After scanning, swap `arr[i+1]` with the pivot at `arr[high]`.
- Now pivot is in its correct sorted location.

Resulting invariant after partition:
- `arr[low .. pi-1] < pivot`
- `arr[pi] == pivot`
- `arr[pi+1 .. high] >= pivot`

## `QuickSort(int arr[], int low, int high)`

Purpose:
- Recursively sort the subarray `arr[low..high]`.

How it works:
- Base case: if `low >= high`, subarray length is 0 or 1, already sorted.
- Recursive case:
  1. Partition and get pivot index `pi`.
  2. Sort left side: `QuickSort(arr, low, pi - 1)`.
  3. Sort right side: `QuickSort(arr, pi + 1, high)`.

## `main()`

- Creates a sample integer array.
- Computes `n` using `sizeof`.
- Calls `QuickSort(arr, 0, n - 1)` on the full array.
- Prints the sorted output.

## 3. Time and Space Complexity of QuickSort

Let `n` be number of elements.

## Time Complexity

- **Best case:** `O(n log n)`
  - Pivot repeatedly splits array into roughly equal halves.
- **Average case:** `O(n log n)`
  - Typical random data gives reasonably balanced splits.
- **Worst case:** `O(n^2)`
  - Happens when splits are highly unbalanced (e.g., already sorted input with poor pivot choice like always-last).

Reasoning:
- Partition step is `O(n)` per level.
- Number of levels is:
  - about `log n` for balanced splits,
  - about `n` for worst unbalanced splits.

## Space Complexity

- **In-place partitioning:** `O(1)` extra array space.
- **Recursion stack:**
  - Best/Average: `O(log n)`
  - Worst: `O(n)`

So total auxiliary space is stack-dominated.

## 4. QuickSort vs MergeSort vs HeapSort vs C++ Built-ins

## QuickSort

- Average time: `O(n log n)`
- Worst time: `O(n^2)` (unless pivot strategy is improved)
- Extra space: `O(log n)` average recursion stack
- Stability: **Not stable** (for typical in-place implementation)
- Practical performance: Often very fast due to cache-friendly sequential partitioning

## MergeSort

- Time: `O(n log n)` in best/average/worst
- Extra space: typically `O(n)` for arrays
- Stability: **Stable**
- When preferred:
  - Need guaranteed `O(n log n)`
  - Need stable sorting
  - Good for linked lists / external sorting

## HeapSort

- Time: `O(n log n)` in best/average/worst
- Extra space: `O(1)`
- Stability: **Not stable**
- When preferred:
  - Need strict worst-case `O(n log n)` with constant extra memory
- Practical note:
  - Often slower than QuickSort / `std::sort` constants in real-world arrays

## C++ built-in methods

## `std::sort` (from `<algorithm>`)

- Typical implementation: **Introsort**
  - Starts like QuickSort
  - Switches to HeapSort when recursion is too deep (avoids `O(n^2)` worst case)
  - Uses insertion sort for tiny partitions
- Complexity: guaranteed `O(n log n)` worst-case
- Stability: **Not stable**
- Usually the best default for general-purpose sorting of arrays/vectors.

## `std::stable_sort`

- Usually merge-sort-based hybrid
- Complexity: typically `O(n log n)` comparisons
- Stability: **Stable**
- Uses extra memory
- Use when preserving equal-element order matters.

## `std::ranges::sort` (C++20)

- Conceptually similar performance/behavior to `std::sort`, but with ranges-friendly interface.

## Practical recommendation

1. Use `std::sort` by default for performance + safety.
2. Use `std::stable_sort` when stability is required.
3. Use custom QuickSort mainly for learning or specialized control (pivot strategies, instrumentation, constraints).

## 5. Notes to improve this QuickSort implementation

- Use randomized pivot or median-of-three pivot to reduce chance of worst-case splits.
- For small partitions, switch to insertion sort to improve constants.
- Tail recursion elimination / loop conversion can reduce stack depth.
