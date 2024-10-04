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

Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

Example

There are  elements, two positive, two negative and one zero. Their ratios are ,  and . Results are printed as:

0.400000
0.400000
0.200000
Function Description

Complete the plusMinus function in the editor below.

plusMinus has the following parameter(s):

int arr[n]: an array of integers
Print
Print the ratios of positive, negative and zero values in the array. Each value should be printed on a separate line with  digits after the decimal. The function should not return a value.

Input Format

The first line contains an integer, , the size of the array.
The second line contains  space-separated integers that describe .

Constraints



Output Format

Print the following  lines, each to  decimals:

proportion of positive values
proportion of negative values
proportion of zeros
Sample Input

STDIN           Function
-----           --------
6               arr[] size n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
Sample Output

0.500000
0.333333
0.166667
Explanation

There are  positive numbers,  negative numbers, and  zero in the array.
The proportions of occurrence are positive: , negative:  and zeros: .

### Solution

My initial thoughts on reading the challenge were as follows:
1. Filter the array to get groups of positive, negative, and zero values.
2. Calculate the ratio for each group.
3. Print the results.

The first issue I encountered was that the ratios should be floats, but we are using integers in the array. Therefore, we need to convert the counts to floats to get the ratio calculation working. Additionally, I noticed that the output needs to have a precision of 6 decimal places. By adjusting the precision in the output print statement, everything worked perfectly.

### Evidence
![image](https://github.com/user-attachments/assets/7ee5fb42-0f8a-4dd7-99ed-41399f963c9d)
