# Mk0.Tools.Randomization
(C) 2019 mk0.at

Allows you to generate a random string with a length of your choice.
You can add an optional prefix and an optional appendix to the random string.

You can use the following methods:

+ NumbersAndDigits (1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw)
+ Digits (ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvw)
+ Numbers (1234567890)

Example usage:

Randomize.NumbersAndDigits(5, "_")
will return f.e. "_j7Ga9"

Randomize.Numbers(2, "*", "#")
will return f.w. "*59#"

Randomize.Digits(3)
will return f.w. "fOu"