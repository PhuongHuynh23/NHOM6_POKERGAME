using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;
using System.Numerics;
using System.Media;
using System.Reflection;
namespace CK
{
    internal class POKER 
    {
        public class Frame
        {
            public static void Screen(int width, int height)
            {
                Console.Clear();


                // Vẽ hàng trên cùng
                Console.WriteLine(new string('-', width + 2));

                // Vẽ các hàng giữa
                for (int i = 0; i < height; i++)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', width));
                    Console.WriteLine("|");
                }

                // Vẽ hàng dưới cùng
                Console.WriteLine(new string('-', width + 2));

            }

            public static void Music()
            {
                SoundPlayer player = new SoundPlayer();
                try
                {
                    SoundPlayer music = new SoundPlayer();
                    var assembly = Assembly.GetExecutingAssembly();
                    Stream soundStream = assembly.GetManifestResourceStream("PROJECT_POKERGAME.brass-fanfare-with-timpani-and-winchimes-reverberated-146260-VEED.wav");
                    music.Stream = soundStream;
                    music.PlayLooping();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Không thể phát nhạc: " + e.Message);
                }
            }
            public static void Drawshowdown()
            {
                string[] showdown = new string[]
               {


@"█▀ █░█ █▀█ █░█░█ █▀▄ █▀█ █░█░█ █▄░█",
@"▄█ █▀█ █▄█ ▀▄▀▄▀ █▄▀ █▄█ ▀▄▀▄▀ █░▀█",
               };



                int startY = 10;  // Vị trí text sẽ bắt đầu từ Y
                int currentY = startY;
                foreach (string s in showdown)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
            }

            public static void Drawwinner()
            {
                string[] drawiner = new string[]
                {

@"▀█▀ █░█ █▀▀   █░█░█ █ █▄░█ █▄░█ █▀▀ █▀█   █ █▀",
@"░█░ █▀█ ██▄   ▀▄▀▄▀ █ █░▀█ █░▀█ ██▄ █▀▄   █ ▄█",
                };
                int startY = 10;  // // Vị trí text sẽ bắt đầu từ Y
                int currentY = startY;
                foreach (string s in drawiner)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
                Console.WriteLine();
            }
            public static void DrawTie()
            {
                string[] drawtie = new string[]
                {

@"▀█▀ █ █▀▀",
@"░█░ █ ██▄",
                };
                int startY = 10;  // Vị trí text sẽ bắt đầu từ Y
                int currentY = startY;
                foreach (string s in drawtie)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
                Console.WriteLine();
            }

        }

        public class Opening
        {
            public static void DrawPoker()
            {
                string[] PokerKing = new string[]
                {

@"██████╗░░█████╗░██╗░░██╗███████╗██████╗░  ██╗░░██╗██╗███╗░░██╗░██████╗░░██████╗",
@"██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗  ██║░██╔╝██║████╗░██║██╔════╝░██╔════╝",
@"██████╔╝██║░░██║█████═╝░█████╗░░██████╔╝  █████═╝░██║██╔██╗██║██║░░██╗░╚█████╗░",
@"██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██╔══██╗  ██╔═██╗░██║██║╚████║██║░░╚██╗░╚═══██╗",
@"██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░░██║  ██║░╚██╗██║██║░╚███║╚██████╔╝██████╔╝",
@"╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝  ╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚═════╝░╚═════╝░",
                };
                int startY = 10;  // Vị trí text sẽ bắt đầu từ Y
                int currentY = startY;
                foreach (string s in PokerKing)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.SetCursorPosition((84) / 2 - s.Length / 2, currentY);

                    Console.WriteLine(s);
                    currentY++;

                }
                Console.ResetColor();
            }

            
            
            public static void MusicOpening()
            {
                SoundPlayer musicOpening = new SoundPlayer();
                var assembly = Assembly.GetExecutingAssembly();
                Stream soundStream = assembly.GetManifestResourceStream("PROJECT_POKERGAME.Wallpaper(chosic-Trimmed by FlexClip (1) (1).wav");
                musicOpening.Stream = soundStream;

                musicOpening.Play();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("                          Press any key to continue....");
                Console.ResetColor();
                Console.ReadKey();

                musicOpening.Stop();
            }
        
        }

        // ---------------------------------------------- Define Card class --------------------------------------------------
        public class Card
        {
            public string Suit { get; private set; } // dùng get và private set để đọc giá trị và
                                                     // không thể thay đổi giá trị từ bên ngoài
            public string Rank { get; private set; }

            public Card(string suit, string rank)
            {
                Suit = suit;
                Rank = rank;
            }

            public override string ToString() // dùng override để ghi đè lên
            {
                return $"{Rank} of {Suit}";
            }
        }

        // ---------------------------------------------- Define Deck class --------------------------------------------------
        public class Deck // giúp quan lí bộ bài trong trò chơi để xào bài và rút bài
        {
            private List<Card> cards;
            private static readonly string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            private static readonly string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            private Random random = new Random();

            public Deck()
            {
                cards = new List<Card>();
                foreach (var suit in suits) // dùng foreach bên trong sẽ duyệt qua tất cả các giá trị suits và ranks 
                                            // để tạo các lá bài thành 52 lá
                {
                    foreach (var rank in ranks)
                    {
                        cards.Add(new Card(suit, rank));
                    }
                }
                Shuffle(); // sau khi tạo xong thì sẽ xào bài
            }

            public void Shuffle() // tráo đổi vị trí của các lá bài 
            {
                int n = cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    Card value = cards[k];
                    cards[k] = cards[n];
                    cards[n] = value; //mỗi lần sẽ chọn ngẫu nhiên một lá bài để tráo đổi vị trí với lá bài hiện tại.


                }
            }

            public Card DealCard()
            {
                if (cards.Count > 0) // nếu true thì tiếp tục và false thì trả về null
                {
                    var card = cards[^1];
                    cards.RemoveAt(cards.Count - 1);
                    return card;
                }
                return null;
            }
        }

        // --------------------------------------------- Define Player class -------------------------------------------------
        public class Player
        {
            public string Name { get; set; }
            public List<Card> Hand { get; set; }
            public int Chips { get; set; }
            public int CurrentBet { get; set; }
            public bool InGame { get; set; }
            public bool HasFolded { get; set; }
            public bool IsAllIn { get; set; }

            public Player(string name)
            {
                Name = name;
                Hand = new List<Card>();
                Chips = 100;
                CurrentBet = 0;
                InGame = true;
                HasFolded = false;
                IsAllIn = false;
            }

            public void ReceiveCard(Card card)
            {
                Hand.Add(card);
            }

            public string ShowHand()
            {
                return string.Join(", ", Hand);
            }

            public void Bet(int amount)
            {
                if (amount >= Chips)
                {
                    AllIn(); // Người chơi tự động all-in nếu không còn đủ chip
                }
                else
                {
                    Chips -= amount;
                    CurrentBet += amount;
                }
            }

            public void Fold()
            {
                InGame = false;
                HasFolded = true;
            }

            public void AllIn()
            {
                CurrentBet += Chips;
                Chips = 0;
                IsAllIn = true;
                InGame = true; // Người chơi vẫn còn trong game, nhưng không thể thêm cược
            }

         
            public void ResetForNewRound()
            {
                CurrentBet = 0;
            }
        }

        // ------------------------------------------ Define HandEvaluator class ---------------------------------------------
        public class HandEvaluator
        {
            public static readonly Dictionary<string, int> rankValues = new Dictionary<string, int>
    {
        { "2", 2 }, { "3", 3 }, { "4", 4 }, { "5", 5 }, { "6", 6 }, { "7", 7 },
        { "8", 8 }, { "9", 9 }, { "10", 10 }, { "J", 11 }, { "Q", 12 }, { "K", 13 }, { "A", 14 }
    };

            public static (int handStrength, string description) EvaluateHand(List<Card> playerHand, List<Card> communityCards)
            {
                var allCards = playerHand.Concat(communityCards).ToList();
                var groupedByRank = allCards.GroupBy(card => card.Rank).ToList();
                var groupedBySuit = allCards.GroupBy(card => card.Suit).ToList();

                // Xác định tay bài
                if (IsFourOfAKind(groupedByRank)) return (8, "Four of a Kind");
                if (IsFullHouse(groupedByRank)) return (7, "Full House");
                if (IsFlush(groupedBySuit)) return (6, "Flush");
                if (IsStraight(allCards)) return (5, "Straight");
                if (IsThreeOfAKind(groupedByRank)) return (4, "Three of a Kind");
                if (IsTwoPair(groupedByRank)) return (3, "Two Pair");
                if (IsOnePair(groupedByRank)) return (2, "One Pair");

                // Nếu không có kết hợp, trả về High Card
                int highCardValue = GetHighCardValue(allCards);
                return (1, $"High Card: {GetCardName(highCardValue)}");
            }

            // Các hàm phụ để xác định loại tay bài
            public static bool IsFourOfAKind(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Any(group => group.Count() == 4);

            public static bool IsFullHouse(List<IGrouping<string, Card>> groupedByRank)
            {
                // Kiểm tra xem có ít nhất một nhóm có 3 quân bài và một nhóm có 2 quân bài
                bool hasThreeOfAKind = groupedByRank.Any(group => group.Count() == 3);
                bool hasPair = groupedByRank.Any(group => group.Count() == 2);

                // Để có một Full House, cần cả 3 quân và 2 quân
                return hasThreeOfAKind && hasPair;
            }

            public static bool IsFlush(List<IGrouping<string, Card>> groupedBySuit) =>
                groupedBySuit.Any(group => group.Count() >= 5);

            public static bool IsStraight(List<Card> allCards)
            {
                // Sắp xếp các lá bài theo giá trị rank, loại bỏ các giá trị trùng lặp và sắp xếp theo thứ tự tăng dần.
                var orderedRanks = allCards
                    .Select(card => rankValues[card.Rank])  // Lấy giá trị rank của mỗi lá bài (được ánh xạ qua `rankValues`)
                    .Distinct()                             // Loại bỏ các giá trị trùng lặp (nếu có)
                    .OrderBy(rank => rank)                  // Sắp xếp thứ tự tăng dần theo rank
                    .ToList();                              // Chuyển sang List để thao tác

                // Nếu tổng số rank khác nhau ít hơn 5, không thể tạo thành sảnh, trả về `false`.
                if (orderedRanks.Count < 5) return false;

                // Kiểm tra xem có chuỗi 5 lá liên tiếp không
                for (int i = 0; i <= orderedRanks.Count - 5; i++)
                {
                    // Nếu 5 lá liên tiếp có khoảng cách giữa lá đầu tiên và cuối cùng bằng 4, đó là sảnh hợp lệ
                    if (orderedRanks[i + 4] - orderedRanks[i] == 4) return true;
                }

                // Xử lý trường hợp đặc biệt: Sảnh "A, 2, 3, 4, 5"
                return orderedRanks.Contains(14) &&  // Nếu có quân Át (A)
                       orderedRanks.Take(4).SequenceEqual(new List<int> { 2, 3, 4, 5 }); // Và 4 quân đầu tiên là {2, 3, 4, 5}
            }

            public static bool IsThreeOfAKind(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Any(group => group.Count() == 3);

            public static bool IsTwoPair(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Count(group => group.Count() == 2) == 2;

            public static bool IsOnePair(List<IGrouping<string, Card>> groupedByRank) =>
                groupedByRank.Any(group => group.Count() == 2);

            // Trả về giá trị lá bài cao nhất
            public static int GetHighCardValue(List<Card> allCards) =>
                allCards.Max(card => rankValues[card.Rank]);

            // Chuyển giá trị lá bài thành tên
            public static string GetCardName(int cardValue)
            {
                return rankValues.FirstOrDefault(x => x.Value == cardValue).Key; //Tìm phần tử có Value bằng cardValue
            }
        }


        // -------------------------------------------- Define PokerGame class -----------------------------------------------
        public class PokerGame
        {
            private Deck deck;
            private List<Player> players;
            private List<Card> communityCards;
            private int totalGamePot;
            private int smallBlindPosition;
            private int bigBlindPosition;
            private const int smallBlindAmount = 5; // Giá trị của small blind
            private const int bigBlindAmount = 10;   // Giá trị của big blind

            public PokerGame(List<Player> players)
            {
                deck = new Deck();
                this.players = players;
                communityCards = new List<Card>();
                totalGamePot = 0;
                smallBlindPosition = 0;
                bigBlindPosition = 1;
            }

            // Phương thức đặt Small Blind và Big Blind
            private void PostBlinds()
            {
                PlaceBlind(smallBlindPosition, smallBlindAmount, "Small Blind");
                PlaceBlind(bigBlindPosition, bigBlindAmount, "Big Blind");

            }

            private void PlaceBlind(int position, int blindAmount, string blindName)
            {
                Player player = players[position];
                player.Bet(blindAmount);
                Console.WriteLine($"{player.Name} posts {blindName} of {blindAmount} chips.");
            }

            public void DealHands()
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var player in players)
                    {
                        player.ReceiveCard(deck.DealCard());
                    }
                }
            }

            public void DealCommunityCards(int num)
            {
                for (int i = 0; i < num; i++)
                {
                    communityCards.Add(deck.DealCard());
                }
            }

            public string ShowCommunityCards()
            {
                return string.Join(", ", communityCards);
            }

            public int PlayerDecision(Player player, int highestBet)
            {
                // Nếu người chơi không còn trong ván hoặc đã bỏ bài, trả về highestBet hiện tại
                if (!player.InGame || player.HasFolded) return highestBet;

                Console.WriteLine($"{player.Name}'s turn. Current chips: {player.Chips}. Highest bet: {highestBet}");

                // Cho phép người chơi chọn hành động với danh sách các hành động hợp lệ
                string[] validActions = new[] { "fold", "call", "raise", "all-in" };
                string action = GetValidAction(player.Name, validActions); // Lấy hành động hợp lệ từ người chơi

                // Xử lý các hành động của người chơi dựa trên lựa chọn của họ
                switch (action)
                {
                    case "fold":
                        player.Fold();
                        Console.WriteLine($"{player.Name} folds."); // Thông báo người chơi đã bỏ bài
                        return highestBet; // Không thay đổi mức cược cao nhất

                    case "call":
                        if (highestBet == 0)
                        {
                            Console.WriteLine($"{player.Name} checks."); // Người chơi kiểm bài
                            return highestBet; // Không thay đổi mức cược cao nhất
                        }
                        else
                        {
                            return ExecuteCall(player, highestBet);
                        }

                    case "raise":
                        return ExecuteRaise(player, highestBet);

                    case "all-in":
                        int allInAmount = player.Chips; // Lấy tổng số chip của người chơi
                        player.AllIn(); // Đánh dấu người chơi đã "all-in"
                        Console.WriteLine($"{player.Name} goes all-in with {allInAmount} chips.");

                        // Cập nhật mức cược cao nhất 
                        return Math.Max(highestBet, player.CurrentBet + allInAmount);
                }

                // Trả về mức cược cao nhất nếu không có hành động hợp lệ nào
                return highestBet;
            }

            private string GetValidAction(string playerName, string[] validActions)
            {
                string action;
                do
                {
                    Console.Write($"{playerName}, choose an action ({string.Join(", ", validActions)}): ");
                    action = Console.ReadLine().Trim().ToLower();
                } while (!validActions.Contains(action));
                return action;
            }

            private int ExecuteCall(Player player, int highestBet)
            {
                int callAmount = highestBet - player.CurrentBet;
                if (player.Chips <= callAmount)
                {
                    // Nếu người chơi không đủ chip để theo, họ sẽ "all-in" với tất cả số chip còn lại
                    callAmount = player.Chips;
                    player.AllIn();
                    Console.WriteLine($"{player.Name} calls and goes all-in with {callAmount} chips.");
                }
                else
                {
                    player.Bet(callAmount);
                    Console.WriteLine($"{player.Name} calls with {callAmount} chips.");
                }

                return highestBet;
            }

            private int ExecuteRaise(Player player, int highestBet)
            {
                int raiseAmount;
                do
                {
                    Console.Write("Enter the raise amount: ");
                } while (!int.TryParse(Console.ReadLine(), out raiseAmount) || raiseAmount <= 0);

                int totalBet = highestBet + raiseAmount;
                if (player.Chips <= (totalBet - player.CurrentBet))
                {
                    // Nếu người chơi không đủ chip để raise, họ sẽ "all-in"
                    totalBet = player.Chips + player.CurrentBet;
                    player.AllIn();
                    Console.WriteLine($"{player.Name} raises and goes all-in with {totalBet} chips.");
                }
                else
                {
                    // Nếu người chơi đủ chip để raise, thực hiện hành động đặt cược
                    player.Bet(totalBet - player.CurrentBet);
                    Console.WriteLine($"{player.Name} raises to {totalBet} chips.");
                }

                return totalBet;
            }

            public enum GameRound { PreFlop, Flop, Turn, River }

            public void StartBettingRound(GameRound round)
            {
                Console.WriteLine($"\nStarting {round} round....");

                // Xác định mức cược cao nhất ban đầu:
                // - Nếu là vòng Pre-Flop, mức cược bắt đầu với số tiền big blind.
                // - Nếu là các vòng khác (Flop, Turn, River), mức cược bắt đầu từ 0.
                int highestBet = (round == GameRound.PreFlop) ? bigBlindAmount : 0;

                // Chỉ đặt small blind và big blind trong vòng Pre-Flop
                if (round == GameRound.PreFlop)
                {
                    PostBlinds();
                }

                BettingRound(highestBet);
            }

            public void BettingRound(int highestBet)
            {
                Console.WriteLine("\nStarting a new betting round....");

                Player currentRaiser = null;
                bool isBettingRoundOver = false;

                // Xác định vị trí bắt đầu của vòng cược
                int startPosition = (highestBet > 0) ? (bigBlindPosition + 1) % players.Count : 0;
                bool bigBlindHasActed = false;

                while (!isBettingRoundOver)
                {
                    isBettingRoundOver = true; // Mặc định là vòng cược sẽ kết thúc, trừ khi có hành động mới

                    for (int i = 0; i < players.Count; i++)
                    {
                        int playerPosition = (startPosition + i) % players.Count;
                        Player player = players[playerPosition];

                        // Bỏ qua người chơi không tham gia, đã fold, hoặc đã all-in
                        if (!player.InGame || player.HasFolded || player.IsAllIn)
                            continue;

                        bool isBigBlind = playerPosition == bigBlindPosition;

                        // Chỉ cho phép hành động nếu highestBet là 0, người chơi chưa đạt highestBet,
                        // hoặc nếu người chơi là big blind và chưa hành động
                        if (highestBet == 0 || player.CurrentBet < highestBet || (isBigBlind && !bigBlindHasActed))
                        {
                            int playerBet = PlayerDecision(player, highestBet);

                            // Nếu người chơi raise, cập nhật highestBet và gán người chơi này làm currentRaiser
                            if (playerBet > highestBet)
                            {
                                highestBet = playerBet;
                                currentRaiser = player;
                                isBettingRoundOver = false;
                            }

                            if (isBigBlind)
                            {
                                bigBlindHasActed = true;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{player.Name} checks automatically as they have matched the highest bet.");
                        }

                        if (CheckForWinner())
                        {
                            return; // Kết thúc vòng cược nếu chỉ còn 1 người chơi
                        }
                    }

                    // Kiểm tra nếu tất cả người chơi đã call, fold, hoặc all-in
                    bool allCalledOrFoldedOrAllIn = players.All(p => !p.InGame || p.CurrentBet >= highestBet || p.HasFolded || p.IsAllIn);
                    if (allCalledOrFoldedOrAllIn)
                    {
                        isBettingRoundOver = true;
                    }
                }

                // Tính tổng pot cho vòng này
                int potForThisRound = CalculateTotalPotForGameRound();
                totalGamePot += potForThisRound;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Total pot for this round: {potForThisRound} chips.");
                Console.ResetColor();

                foreach (var player in players)
                {
                    player.ResetForNewRound();
                }
            }

            public int CalculateTotalPotForGameRound()
            {
                int pot = 0;
                foreach (Player player in players)
                {
                    pot += player.CurrentBet;
                }
                return pot;
            }

            private bool CheckForWinner()
            {
                int activePlayers = players.Count(p => p.InGame && !p.HasFolded);

                if (activePlayers == 1)
                {
                    PauseAndClear();
                    Frame.Music();
                    // Xác định người chơi duy nhất còn lại
                    Player winner = players.First(p => p.InGame && !p.HasFolded);

                    // Cộng tổng pot vào số chip của người thắng
                    winner.Chips += totalGamePot;

                    // Hiển thị thông báo người chiến thắng và số tiền thắng được
                    Frame.Drawwinner();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"                   {winner.Name} wins the game as all other players have folded.");
                    Console.WriteLine($"                             {winner.Name} wins the pot of {totalGamePot} chips!");
                    Console.ResetColor();
                    Console.WriteLine();

                    SaveResult();

                    return true; // Kết thúc trò chơi
                }

                return false; // Tiếp tục trò chơi
            }

           private List<Player> FindWinner()
        { 
                
            List<Player> winners = new List<Player>(); // Danh sách lưu trữ những người chơi chiến thắng
            int bestHandStrength = 0;
            int bestHighCard = 0;

            // Kiểm tra nếu bài của người chơi hiện tại mạnh hơn bài mạnh nhất hiện tại
             foreach (var player in players.Where(p => p.InGame && !p.HasFolded))
             {
             var (handStrength, _) = HandEvaluator.EvaluateHand(player.Hand, communityCards); // Đánh giá sức mạnh của bộ bài
              int playerHighCard = HandEvaluator.GetHighCardValue(player.Hand.Concat(communityCards).ToList()); // Lấy giá trị high card của người chơi

             if (handStrength > bestHandStrength)
             {
               bestHandStrength = handStrength; // Cập nhật giá trị mạnh nhất
               bestHighCard = playerHighCard;   // Cập nhật giá trị high card cao nhất
            winners.Clear(); // Xóa danh sách người thắng cũ
            winners.Add(player); // Thêm người chơi này vào danh sách người thắng
             }
               else if (handStrength == bestHandStrength)
               {
           if (handStrength == 1) // Trường hợp cả hai tay bài đều là High Card
           {
               if (playerHighCard > bestHighCard) // Nếu high card của người chơi hiện tại lớn hơn
               {
                    bestHighCard = playerHighCard; // Cập nhật giá trị high card cao nhất
                    winners.Clear(); // Xóa danh sách người thắng cũ
                    winners.Add(player); // Thêm người chơi này vào danh sách người thắng
               }
               else if (playerHighCard == bestHighCard)
               {
                    winners.Add(player); // Thêm người chơi nếu high card bằng nhau
               }
            }
           else
           {
                winners.Add(player); // Thêm người chơi vào danh sách nếu bài của họ mạnh bằng bài mạnh nhất
           }
        }
    }

            return winners;
}


            private void Showdown()
            {
                DisplayLeaderboard();
                List<Player> winners = FindWinner();

                // Kiểm tra nếu chỉ có một người chiến thắng
                if (winners.Count == 1)
                {
                    Frame.Drawwinner();
                    AwardWinner(winners[0]); // Trao giải thưởng cho người thắng duy nhất
                }
                else
                {
                    Frame.DrawTie();
                    SplitPotAmongWinners(winners); // Chia pot cho tất cả những người thắng
                }
            }

            private void AwardWinner(Player winner)
            {
                var (_, handDescription) = HandEvaluator.EvaluateHand(winner.Hand, communityCards); // Lấy mô tả tay bài của người thắng
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(@$"                                         {winner.Name}!!!
                         {winner.Name} wins the pot of {totalGamePot} chips with a {handDescription}!");
                winner.Chips += totalGamePot; // Cộng toàn bộ số tiền pot vào số chip của người thắng
                Console.ResetColor();
            }

            private void SplitPotAmongWinners(List<Player> winners)
            {
                int splitAmount = totalGamePot / winners.Count; // Chia đều pot cho người chơi
                int remainder = totalGamePot % winners.Count; // Tính số chip còn dư sau khi chia

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(@$"                              The pot of {totalGamePot} chips 
                                                   will be split among {winners.Count} players.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine();

                // Duyệt qua từng người chơi thắng và trao chip
                foreach (var winner in winners)
                {
                    int chipsAwarded = splitAmount + (remainder > 0 ? 1 : 0); // Trao thêm 1 chip nếu còn dư
                    if (remainder > 0) remainder--; // Giảm số dư sau khi trao thêm chip

                    winner.Chips += chipsAwarded;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"                                   {winner.Name} receives {chipsAwarded} chips.");
                    Console.ResetColor();
                }
            }

            public void DisplayLeaderboard()
{
    // Lọc danh sách người chơi chỉ bao gồm những người không bỏ bài

             var activePlayers = players
             .Where(p => p.InGame && !p.HasFolded)
               .ToList();

               if (activePlayers.Count == 0)
               {
                 Console.WriteLine("No active players available.");
                 return;
                 }

               // Mảng 2D để lưu thông tin bảng xếp hạng: Tên, Mức độ mạnh của bài, Mô tả bài
               object[,] leaderboard = new object[activePlayers.Count, 4];

               // Điền thông tin vào leaderboard cho các người chơi đủ điều kiện
             for (int i = 0; i < activePlayers.Count; i++)
              {
               Player player = activePlayers[i];
              var (handStrength, handDescription) = HandEvaluator.EvaluateHand(player.Hand, communityCards);
              int highCardValue = HandEvaluator.GetHighCardValue(player.Hand.Concat(communityCards).ToList()); // Lấy giá trị high card

                 leaderboard[i, 0] = player.Name;           // Tên người chơi
               leaderboard[i, 1] = handStrength;          // Sức mạnh bài
               leaderboard[i, 2] = handDescription;       // Mô tả bài
                   leaderboard[i, 3] = highCardValue;         // Giá trị high card
            }

               // Sắp xếp bảng xếp hạng theo sức mạnh bài (giảm dần) bằng Bubble Sort
              for (int i = 0; i < activePlayers.Count - 1; i++)
                  {
                  for (int j = i + 1; j < activePlayers.Count; j++)
                  {
                 // So sánh sức mạnh bài
                  int strengthComparison = Convert.ToInt32(leaderboard[i, 1]).CompareTo(Convert.ToInt32(leaderboard[j, 1]));
                     // Nếu sức mạnh bài bằng nhau, so sánh high card
                  if (strengthComparison == 0)
                  {
                 strengthComparison = Convert.ToInt32(leaderboard[i, 3]).CompareTo(Convert.ToInt32(leaderboard[j, 3]));
                      }

                       // Hoán đổi nếu cần
                   if (strengthComparison < 0) // Nếu bài i mạnh hơn bài j
                   {
                   SwapRows(leaderboard, i, j); // Hoán đổi vị trí
              }
         }
    }


             // Hiển thị bảng xếp hạng đã sắp xếp
               Frame.Screen(84, 28);
               Frame.Music();
               Frame.Drawshowdown();
                for (int i = 0; i < activePlayers.Count; i++)
                 {
                 int rank = i + 1;

                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.WriteLine($"                    #{rank}. Player {leaderboard[i, 0]} - Hand Strength: {leaderboard[i, 1]} - {leaderboard[i, 2]}");
                 Console.ResetColor();
                 }
                 Console.WriteLine("                          Press any key to continue...");
                 Console.ReadKey();

               Frame.Screen(84, 28);
              Console.SetCursorPosition((84) / 2 - 5, 28 / 2);
}


            private void SwapRows(object[,] array, int row1, int row2)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    var temp = array[row1, col];
                    array[row1, col] = array[row2, col];
                    array[row2, col] = temp;
                }
            }

            public void SaveResult()
            {
                try
                {
                    string filePath = "PokerGameResult.txt";  // Tên file để lưu kết quả trò chơi
                    using (StreamWriter writer = new StreamWriter(filePath, true))  // Mở file ở chế độ thêm (append)
                    {
                        writer.WriteLine($"Game Result: {DateTime.Now}"); // Ghi ngày giờ kết quả trò chơi
                                                                          // Ghi tên và số chip của từng người chơi
                        foreach (var player in players)
                        {
                            writer.WriteLine($"{player.Name}: {player.Chips} chips");
                        }
                        writer.WriteLine($"Total Pot: {totalGamePot} chips");
                        writer.WriteLine("------------------------------");
                    }
                    Console.WriteLine("                              Game result saved successfully.");
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi xảy ra trong quá trình lưu, thông báo lỗi
                    Console.WriteLine($"An error occurred while saving the result: {ex.Message}");
                }
            }

            public void Play()
            {
                DealHands(); // Phát bài cho người chơi

                Console.WriteLine("Player hands at the start:");
                // Hiển thị bài của từng người chơi
                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE PRE-FLOP...");
                Console.ResetColor();

                // Vòng cược đầu tiên (Pre-Flop) với blinds
                StartBettingRound(GameRound.PreFlop);
                if (CheckForWinner()) return;
                Console.WriteLine($"Final pot after all betting rounds: {totalGamePot} chips");
                PauseAndClear();

                // Chia Flop (3 lá bài)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE FLOP...");
                Console.ResetColor();
                DealCommunityCards(3); // Chia 3 lá bài cộng đồng
                ShowCommunityAndPlayerHands();

                // Vòng cược thứ hai (Flop)
                StartBettingRound(GameRound.Flop);
                if (CheckForWinner()) return; // Kiểm tra người thắng
                Console.WriteLine($"Final pot after all betting rounds: {totalGamePot} chips");
                PauseAndClear();

                // Chia Turn (1 lá bài)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE TURN...");
                Console.ResetColor();
                DealCommunityCards(1); // Chia 1 lá bài cộng đồng
                ShowCommunityAndPlayerHands();

                // Vòng cược thứ ba (Turn)
                StartBettingRound(GameRound.Turn);
                if (CheckForWinner()) return; // Kiểm tra người thắng
                Console.WriteLine($"Final pot after all betting rounds: {totalGamePot} chips");
                PauseAndClear();

                // Chia River (1 lá bài)
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDEALING THE RIVER...");
                Console.ResetColor();
                DealCommunityCards(1); // Chia 1 lá bài cộng đồng
                ShowCommunityAndPlayerHands();

                // Vòng cược cuối (River)
                StartBettingRound(GameRound.River);
                if (CheckForWinner()) return; // Kiểm tra người thắng

                // Hiển thị tổng số pot sau tất cả các vòng cược
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Final pot after all betting rounds: {totalGamePot} chips");
                Console.ResetColor();
                Pause();

                Showdown();
                SaveResult();
            }

            // Helper methods

            private void ShowCommunityAndPlayerHands()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Community Cards: {ShowCommunityCards()}");
                Console.ResetColor();

                foreach (var player in players)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{player.Name}'s hand: {player.ShowHand()}");
                    Console.ResetColor();
                }
            }

            private void PauseAndClear()
            {
                Thread.Sleep(5000);
                Console.Clear();
            }

            private void Pause()
            {
                Thread.Sleep(5000);
            }
        }




        // ---------------------------------------- Main program to initiate a game ------------------------------------------
        public class Program
        {
            public static void Main()
            {
                Frame.Screen(84, 28);
                Console.OutputEncoding = Encoding.UTF8;
                Opening.DrawPoker();
                Console.WriteLine();
                Opening.MusicOpening();
                SoundPlayer effect1 = new SoundPlayer();

                int numPlayers = 0;
                SoundPlayer sound = new SoundPlayer();
                var assembly = Assembly.GetExecutingAssembly();
                Stream soundStream = assembly.GetManifestResourceStream("PROJECT_POKERGAME.mix-3m41s-audio-joinercom_0vmZcQv6 (1) (1).wav");
                sound.Stream = soundStream;

                sound.Play();
                do
{
    Console.Clear();
    Frame.Screen(84, 28);
    Console.SetCursorPosition(60 / 2 - 5, 22 / 2);

    Console.Write("Enter the number of players (min:2 & max:5): ");
    string input = Console.ReadLine();

    // Kiểm tra đầu vào có hợp lệ và có nằm trong khoảng 2-5 không
    if (int.TryParse(input, out numPlayers) && numPlayers >= 2 && numPlayers <= 5)
    {
        break; // Nếu đúng, thoát khỏi vòng lặp
    }
    else
    {
        Console.WriteLine("                      Invalid input. Please enter a number between 2 and 5.");
        System.Threading.Thread.Sleep(2000); // Chờ 2 giây để người chơi đọc thông báo
    }
} while (true);
                Console.WriteLine();

                var players = new List<Player>();
                for (int i = 0; i < numPlayers; i++)
                {
                    Console.Write($"                              Enter the name of player {i + 1}: ");
                    string playerName = Console.ReadLine();
                    players.Add(new Player(playerName));
                }
                Console.Clear();
                sound.Stop();
                PokerGame game = new PokerGame(players);
                game.Play();
                Console.ReadKey();
            }
        }

    }
}





