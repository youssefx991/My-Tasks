# Task

An ASP.NET Core MVC chat app with a ChatGPT-like interface, session-backed history, and OpenAI Chat Completions integration using `gpt-4o-mini`.

## Setup

1. Set the OpenAI API key in an environment variable named `OpenAI__ApiKey`.
2. Run the app with `dotnet run` from the project root.
3. Open the site in the browser and start chatting.

## Configuration

The app reads these settings from the `OpenAI` configuration section:

- `Endpoint` defaults to `https://api.openai.com/v1/chat/completions`
- `Model` defaults to `gpt-4o-mini`
- `SystemPrompt` controls the assistant behavior

Do not commit API keys into source control. The key that was shared in chat should be rotated and replaced with a fresh secret stored only in your environment.

## Behavior

- Every message is stored in the current session.
- The full conversation history is sent to the model on each reply.
- Press `Enter` to send, or `Shift+Enter` for a new line.