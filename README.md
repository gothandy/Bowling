# Bowling
## Introduction
[Bowling - Coding Dojo](http://codingdojo.org/kata/Bowling/)

## Simple As
The idea with this branch was to use a string based scorecard with space seperators.
I split this string down and created [Frame](BowlingLibrary/Frame.cs) objects that did their own converting of characters.

The key insight here was to group the final frame throws together. This is how standard bowling score sheets work.
I found this image useful to visualise the frames and calculate the perfect score.

[300 Game Image](http://ten-pin-bowling.com/how-to-bowl/images/300game.jpg)

As with other attempts I came unstuck on the Double Strike sceanrio. With this approach I also found it hard to debug the issues.
In the final refactoring moved all the Score Sheet string to Throws array logic in [ScoreSheet](BowlingLibrary/ScoreSheet.cs).
