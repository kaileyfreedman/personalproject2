# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

A person would run my program to guess 5 letter words for entertainment. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can perform a word guessing game.

### 3a iii.
Describes the input and output of the program demonstrated in the video.

My program accepts input from the keyboard. It outputs the word guessed with colors that indicate whether each character is in the word and in the correct position, if it is in the word and in the incorrect position, or if it is not in the word at all. If the word is not 5 characters, it outputs an error message.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> words = new List<string>();

words.Add("ahead");
words.Add("break");
words.Add("alone");
words.Add("glass");
words.Add("chart");
words.Add("horse");
words.Add("giant");
words.Add("focus");
words.Add("moral");
words.Add("night");
words.Add("youth");
words.Add("smile");
words.Add("laugh");
words.Add("valid");
words.Add("truth");
words.Add("stone");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
    Random generator = new Random();
    int index = generator.Next(0, words.Count);

    string randomWord = words[index];
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable words.

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the different words that are randomly generated to be guessed. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity because I could easily add more words without changing my code. Without the loop, I would have to create additional variables each time I add a question. 


## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static void DisplayInfo(string guess, string correct)
{
    if (guess.Length != correct.Length)
    {
    throw new Exception ("The guess is not the same length as the correct word.");
    }
    else
    {
        int ix = 0;
        foreach (char c in guess)
        {
            DisplayCharInfo(c, ix, correct);
            ix = ix+1; 
        }
    }
}
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
while  (guess != correct)
{

    guess = GetGuess(correct);
    DisplayInfo(guess, correct);
    Console.WriteLine();
}
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

At a high level, this method, given a guess and the correct word to be guessed, displays the guess to the screen coloring each character based on its position and if it is in the correct word. This is a crucial part to the functionality of my program because it used every time the player makes a guess. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

    1. Validate that the guess and correct word are the same length
    2. If the lengths do not match, throw an exception
    3. If they match, iterate through each character:
    4. Use the DisplayCharInfo method to determine what color to print the character
   
## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

Program.DisplayInfo("fight", "brown");

Second call:

Program.DisplayInfo("tree", "beach");

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This call tests what happens when the guessed word is the same length as the correct word.

Condition(s) tested by the second call:

This call tests what happens when the guessed word is not the same length as the correct word.

### 3d iii.

Result of the first call:

You should see a red F, I, G, H, and T.

Result of the second call:

The result of this is an exception is thrown that says the guess is invalid and asks again for a valid input.