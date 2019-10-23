## Background
This is a WinForm application

## Issue
On Window 10:
- Case 1: When the error is throw out from the MainWindow constructor, the application will turn into suspend status
- Case 2: When the error is throw out from a button click event, an error dialog(JIT error) will pop up and after close it, the application will terminated

On Window 7:
Both cases can cause the application to shutdown without going to the suspend status