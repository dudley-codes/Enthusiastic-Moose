using System;

Main();

void Main()
{
Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();
}

// Ask a question
  MooseQuestions("Are you enthusiastic?", "yay!", "You should try it!");
  MooseQuestions("Do you love C# yet?", "Good job sucking up to your instructor!", "You will... oh, yes, you will...");
  MooseQuestions("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
 

void MooseQuestions(string question, string yesAnswer, string noAnswer)
{
    bool isTrue = MooseAsks(question);
    if(isTrue)
    {
      MooseSays(yesAnswer);
    }
    else 
    {
      MooseSays(noAnswer);
    }
};

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");

};

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}
