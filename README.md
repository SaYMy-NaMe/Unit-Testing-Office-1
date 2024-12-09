# Stack Implementation with NUnit Tests

This project implements a simple stack data structure with basic operations such as `Push`, `Pop`, `Top`, and `IsEmpty`. It also includes a set of NUnit tests to verify the correct behavior of these operations under various conditions, including handling underflow and verifying that elements are removed in the correct order.

## Features

- **Push**: Adds an element to the top of the stack.
- **Pop**: Removes and returns the element at the top of the stack.
- **Top**: Returns the element at the top of the stack without removing it.
- **IsEmpty**: Checks if the stack is empty.
- **Size**: Returns the number of elements currently in the stack.

## NUnit Test Cases

The following test cases are implemented to validate the behavior of the stack:

### 1. **Verify that IsEmpty is true for a new stack**
   - A new stack is created, and the `IsEmpty` method should return `true`.

### 2. **Push a single element and verify IsEmpty and size**
   - After pushing a single object onto the stack, `IsEmpty` should return `false`, and the stack size should be `1`.

### 3. **Push three elements and verify size**
   - Three elements are pushed onto the stack, and the size should be `3`.

### 4. **Pop an element from a stack with 3 elements**
   - An element is popped from the stack, and the size should now be `2`.

### 5. **Push and Pop a single element, verify IsEmpty and size**
   - After pushing and popping a single element, `IsEmpty` should return `true`, and the size should be `0`.

### 6. **Push a single element and verify equality after Pop**
   - A single object is pushed onto the stack, and after popping, the object is verified to be the same as the one that was pushed.

### 7. **Push three objects and verify the order after Pop**
   - Three elements are pushed onto the stack. After popping, the elements should be removed in the reverse order of insertion (LIFO: Last In, First Out).

### 8. **Pop from an empty stack (underflow condition)**
   - Popping from an empty stack should throw an `InvalidOperationException` (underflow condition).

### 9. **Push a single object, then call Top**
   - After pushing a single object, `Top` should return the same object without removing it. `IsEmpty` should return `false`.

### 10. **Push a single object and verify Top returns the same object**
   - After pushing an object, `Top` should return the object that was pushed, without removing it from the stack.

### 11. **Call Top on an empty stack (underflow condition)**
   - Calling `Top` on an empty stack should throw an `InvalidOperationException` (underflow condition).

## Requirements

- **.NET Framework** or **.NET Core**
- **NUnit** for unit testing

## How to Run the Tests

1. Clone the repository or download the source code.
2. Open the solution in Visual Studio or your preferred .NET IDE.
3. Ensure NUnit is installed via NuGet in your project.
4. Build the solution.
5. Run the tests using the NUnit test runner or Visual Studio's built-in test tools.

```bash
dotnet test
