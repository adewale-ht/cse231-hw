# W02 Journal Program Explanation

## Overview
This project is a simple console-based Journal application for CSE 210. It helps users write daily journal entries by providing random prompts, and allows saving/loading entries to/from a file.

## File Structure
- **Entry.cs**: Defines the `Entry` class, which models a single journal entry with a date, prompt, and response.
- **Journal.cs**: Defines the `Journal` class, which manages a list of entries, provides prompts, and handles writing, displaying, saving, and loading entries.
- **Program.cs**: Contains the main menu and program flow, allowing the user to interact with the journal.

## Features
- Write a new entry with a random prompt and current date.
- Display all journal entries with their date, prompt, and response.
- Save the journal to a file (entries separated by `|`).
- Load the journal from a file.
- Menu-driven interface for user interaction.

## Creativity
- Entries can include tags (e.g., #tag) in the response, which are displayed with each entry.
- The program is designed for easy extension (e.g., more prompts, additional entry fields).

## How It Works
1. The user selects an option from the menu.
2. For writing, a random prompt is shown and the user's response is saved with the date.
3. For displaying, all entries are printed to the console.
4. For saving/loading, the user provides a filename and the journal is written to or read from that file.

## Exceeding Requirements
- The program supports tags in entries for better organization.
- The code is organized with each class in its own file, following C# conventions.

---
Feel free to modify or extend this explanation as needed for your submission.
