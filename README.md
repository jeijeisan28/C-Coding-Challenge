# 📱 Old Phone Pad Challenge

## Problem

Simulate typing on an old mobile phone keypad. Each number corresponds to a set of letters.
Pressing a button cycles through its letters. `*` represents backspace, a space (` `) separates sequences on the same button, and `#` indicates the end of input.

## Examples

```csharp
OldPhonePad("33#") => "E"
OldPhonePad("227*#") => "B"
OldPhonePad("4433555 555666#") => "HELLO"
OldPhonePad("8 88777444666*664#") => "????"
```

## Features

- Keypad simulation with cycling characters
- Handles backspaces
- Respects pauses between sequences
- Modular and tested

## Usage

```csharp
Console.WriteLine(OldPhone.OldPhonePad("4433555 555666#")); // HELLO
```

## Requirements

- .NET Core / .NET 5+
- C# 8.0+
