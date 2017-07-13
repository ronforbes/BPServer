using System;

namespace BPServer {
    public class GameResults {
        public string Name;
        public int Score;

        public GameResults(string name, int score) {
            Name = name;
            Score = score;
        }
    }
}