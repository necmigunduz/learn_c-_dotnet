Random dice = new Random();

int roll = dice.Next(1, 7);

string result = "";

if (roll > 3) {
    result = $"It is your lucky day! You got {roll}!";
} else {
    result = $"Ohh! Bad luck! You got {roll}! Wish you good luck for next time!";
};

Console.WriteLine(result);

Random res = new();
int r = res.Next();

Console.WriteLine(r);