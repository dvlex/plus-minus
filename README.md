# Hacker Rank - 1 Month Preparation Kit
## Plus Minus

### Introduction

This is a series of exercises included in the "1 Month Preparation Kit" within HackerRank preparation kits. I am developing these solutions inside devcontainers to solve the different challenges in various programming languages that I know, such as:
- C#
- Python
- TypeScript
- Ruby

Additionally, I will assign different difficulty levels to each challenge, starting with console applications. Once the entire series is completed, I will display the results in a web application.

### Prerequisites

To run this devcontainer, you need:
- Linux, Mac, or Windows with WSL
- Docker
- Visual Studio Code
- Git

### Usage

Open this repository in VSCode (in CLI, open the repo folder and type `code .`). Press Ctrl + Shift + P, and type "Reopen in Container" to enter the devcontainer. Once inside the devcontainer, navigate to the file `Program.cs` and run it using the play button above.
![image](https://github.com/user-attachments/assets/be3f28fa-b04f-4515-b8b9-5c9be0158cd6)


### Challenge

Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with six places after the decimal.

**Note:** This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with an absolute error of up to \(10^{-4}\) are acceptable.

**Example:**

There are 5 elements: two positive, two negative, and one zero. Their ratios are \( \frac{2}{5} \), \( \frac{2}{5} \), and \( \frac{1}{5} \). Results are printed as:

```
0.400000
0.400000
0.200000
```

**Function Description:**

Complete the `plusMinus` function in the editor below.

`plusMinus` has the following parameter(s):

- `int arr[n]`: an array of integers

**Print:**

Print the ratios of positive, negative, and zero values in the array. Each value should be printed on a separate line with six digits after the decimal. The function should not return a value.

**Input Format:**

- The first line contains an integer, \( n \), the size of the array.
- The second line contains \( n \) space-separated integers that describe `arr[n]`.

**Constraints:**

- \( 0 < n \leq 100 \)
- \( -100 \leq arr[i] \leq 100 \)

**Output Format:**

Print the following three lines, each to six decimals:

1. Proportion of positive values
2. Proportion of negative values
3. Proportion of zeros

**Sample Input:**

```
STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
```

**Sample Output:**

```
0.500000
0.333333
0.166667
```

**Explanation:**

There are 3 positive numbers, 2 negative numbers, and 1 zero in the array. The proportions of occurrence are positive: \( \frac{3}{6} \), negative: \( \frac{2}{6} \), and zeros: \( \frac{1}{6} \).

### Solution

My initial thoughts on reading the challenge were as follows:
1. Filter the array to get groups of positive, negative, and zero values.
2. Calculate the ratio for each group.
3. Print the results.

The first issue I encountered was that the ratios should be floats, but we are using integers in the array. Therefore, we need to convert the counts to floats to get the ratio calculation working. Additionally, I noticed that the output needs to have a precision of 6 decimal places. By adjusting the precision in the output print statement, everything worked perfectly.

### Evidence
![image](https://github.com/user-attachments/assets/7ee5fb42-0f8a-4dd7-99ed-41399f963c9d)
