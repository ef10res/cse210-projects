using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string comment;

        List<Video> _videos = new List<Video>();
        Video vd1 = new Video("How to shoot a soccer ball", "Freekicker", 120);
        vd1._comments = new List<Comment>()
        {
            new Comment { _name = "Gerrard", _text ="I can do better than that"},
            new Comment { _name = "Beckham", _text = "That is easy"},
            new Comment { _name = "Messi", _text = "Is this for begginers?"}
        };
        
        Video vd2 = new Video("Baking a cake", "Yourchef", 180);
        vd2._comments = new List<Comment>()
        {
            new Comment { _name = "Sofia", _text ="That looks great"},
            new Comment { _name = "Laura", _text = "I'm going to try this recipe next time"},
            new Comment { _name = "Mary", _text = "I tried it and it worked!"}
        };

        Video vd3 = new Video("How to change a tire", "DIYfriends", 280);
        vd3._comments = new List<Comment>()
        {
            new Comment { _name = "Carlos", _text ="I didn't get the part on minute 2:34"},
            new Comment { _name = "John", _text = "I'm a mechanic and this is not the right way"},
            new Comment { _name = "Alex", _text = "I'm confused"}
        };

        _videos.Add(vd1);
        _videos.Add(vd2);
        _videos.Add(vd3);


        foreach (Video video in _videos)
        {
            Console.WriteLine($"{video._title}, {video._author}, {video._length} seconds");
            Console.WriteLine($"comments: {video.CommentCount()}");
            Console.WriteLine($"{video._comments[0]._name} '{video._comments[0]._text}'");
            Console.WriteLine($"{video._comments[1]._name} '{video._comments[1]._text}'");
            Console.WriteLine($"{video._comments[2]._name} '{video._comments[2]._text}'");
            Console.WriteLine();
        }
    }
}