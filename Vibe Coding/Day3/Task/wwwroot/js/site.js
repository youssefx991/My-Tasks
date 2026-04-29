// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

document.addEventListener("DOMContentLoaded", () => {
	const chatMessages = document.getElementById("chatMessages");
	if (chatMessages) {
		chatMessages.scrollTop = chatMessages.scrollHeight;
	}

	const replyToMessageId = document.getElementById("replyToMessageId");
	const replyToContent = document.getElementById("replyToContent");
	const replyBanner = document.getElementById("replyBanner");
	const replyBannerContent = document.getElementById("replyBannerContent");
	const clearReplyButton = document.getElementById("clearReplyButton");

	const chatInput = document.querySelector(".chat-input");
	if (chatInput) {
		chatInput.addEventListener("keydown", (event) => {
			if (event.key === "Enter" && !event.shiftKey) {
				event.preventDefault();
				const form = chatInput.closest("form");
				if (form) {
					form.requestSubmit();
				}
			}
		});
	}

	document.querySelectorAll(".reply-button").forEach((button) => {
		button.addEventListener("click", () => {
			const messageId = button.getAttribute("data-message-id") || "";
			const messageContent = button.getAttribute("data-message-content") || "";

			if (replyToMessageId) {
				replyToMessageId.value = messageId;
			}

			if (replyToContent) {
				replyToContent.value = messageContent;
			}

			if (replyBanner && replyBannerContent) {
				replyBanner.classList.remove("d-none");
				replyBannerContent.textContent = messageContent;
			}

			if (chatInput) {
				chatInput.focus();
			}
		});
	});

	if (clearReplyButton) {
		clearReplyButton.addEventListener("click", () => {
			if (replyToMessageId) {
				replyToMessageId.value = "";
			}

			if (replyToContent) {
				replyToContent.value = "";
			}

			if (replyBanner) {
				replyBanner.classList.add("d-none");
			}

			if (replyBannerContent) {
				replyBannerContent.textContent = "";
			}
		});
	}
});
