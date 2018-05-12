using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class MoviePics : Form
    {
        User newUser = new User();
        int index = 0;

        List<Movie> movieList = new List<Movie>();
        Dictionary<Movie, int> movieDictionary = new Dictionary<Movie, int>();

        public MoviePics(User myUser)
        {
            InitializeComponent();
            newUser = myUser;
        }

        private void MoviePics_Load(object sender, EventArgs e)
        {
            AddMovies();
            AddDictionary();
            //userGreetingLabel.Text = "Welcome " + newUser.firstName + " " + newUser.lastName;
            MovieDisplay();

            voteComboBox.Items.AddRange(new Object[] {new Vote("5", 2), new Vote("4", 1), new Vote("3", 0), new Vote("2", -1), new Vote("1", -2) });
        }

        private void prefButton_Click(object sender, EventArgs e)
        {
            Preferences prefButton = new Preferences();
            prefButton.Show();
            this.Hide();
        }

        public void MoviePicker()
        {
            int i = 0;
            int score = 0;
            index = 0;
            AddDictionary();


            foreach (KeyValuePair<Movie, int> set in movieDictionary)
            {
                
                if (set.Value >= score && movieList[i].Watched == false && movieList[i].Skip == false)
                {
                    index = i;
                    score = set.Value;
                }

                else if (score == 0 && set.Value < score && movieList[i].Watched == false && movieList[i].Skip == false)
                {
                    index = i;
                    score = set.Value;
                }

                i++;
            }
        }

        public void AddDictionary()
        {
            movieDictionary.Clear();

            foreach (Movie m in movieList)
            {
                movieDictionary.Add(m, ScoreMovie(m, newUser));
            }
        }
        
        public int ScoreMovie(Movie m, User e, int score = 0)
        {
            
            if (m.Romance == true)
            {
                score += e.romance;
            }

            if (m.Comedy == true)
            {
                score += e.comedy;
            }

            if (m.Drama == true)
            {
                score += e.drama;
            }

            if (m.Horror == true)
            {
                score += e.horror;
            }

            return score;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int voteScore = 0;
            try
            {
                Vote vote = (Vote)voteComboBox.SelectedItem;
                voteScore = vote.Num;
                movieList[index].Watched = true;

                if (movieList[index].Romance == true)
                {
                    newUser.romance += voteScore;
                }

                if (movieList[index].Comedy == true)
                {
                    newUser.comedy += voteScore;
                }

                if (movieList[index].Drama == true)
                {
                    newUser.drama += voteScore;
                }

                if (movieList[index].Horror == true)
                {
                    newUser.horror += voteScore;
                }
                
                MovieDisplay();

                voteComboBox.SelectedIndex = -1;
            }
            catch (NullReferenceException)
            {

            }
        }

        private void MovieDisplay()
        {
            MoviePicker();

            movieNameLabel.Text = movieList[index].Name;
            movieInfoLabel.Text = movieList[index].Description;
            SetImage();            
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            movieList[index].Skip = true;
            MovieDisplay();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            index = rnd.Next(0, movieList.Count);

            movieNameLabel.Text = movieList[index].Name;
            movieInfoLabel.Text = movieList[index].Description;
            SetImage();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetImage()
        {
            switch (movieList[index].Pic)
            {
                case "Saw":
                    moviePicBox.Image = Properties.Resources.Saw;
                    break;

                case "Trading":
                    moviePicBox.Image = Properties.Resources.Trading;
                    break;

                case "PrincessBride":
                    moviePicBox.Image = Properties.Resources.PrincessBride;
                    break;

                case "Game":
                    moviePicBox.Image = Properties.Resources.Game;
                    break;

                case "Friday":
                    moviePicBox.Image = Properties.Resources.Friday;
                    break;

                case "Sleepless":
                    moviePicBox.Image = Properties.Resources.Sleepless;
                    break;

                case "Showgirls":
                    moviePicBox.Image = Properties.Resources.Showgirls;
                    break;

                case "Slumdog":
                    moviePicBox.Image = Properties.Resources.Slumdog;
                    break;

                case "Chappie":
                    moviePicBox.Image = Properties.Resources.Chappie;
                    break;

                case "Deathday":
                    moviePicBox.Image = Properties.Resources.Deathday;
                    break;

                case "AboveBelow":
                    moviePicBox.Image = Properties.Resources.AboveBelow;
                    break;

                case "It":
                    moviePicBox.Image = Properties.Resources.It;
                    break;

                case "Blended":
                    moviePicBox.Image = Properties.Resources.Blended;
                    break;

                case "CaptainUnderpants":
                    moviePicBox.Image = Properties.Resources.CaptainUnderpants;
                    break;

                case "DisasterArtist":
                    moviePicBox.Image = Properties.Resources.DisasterArtist;
                    break;

                case "FistFight":
                    moviePicBox.Image = Properties.Resources.FistFight;
                    break;

                case "MeBefore":
                    moviePicBox.Image = Properties.Resources.MeBefore;
                    break;

                case "ShapeWater":
                    moviePicBox.Image = Properties.Resources.ShapeWater;
                    break;

                case "HarrySally":
                    moviePicBox.Image = Properties.Resources.HarrySally;
                    break;

                case "Beauty":
                    moviePicBox.Image = Properties.Resources.Beauty;
                    break;

                default:
                    break;
            }

            moviePicBox.Refresh();
            moviePicBox.Visible = true;
        }

        public void AddMovies()
        {
            Movie princess = new Movie();
            princess.Name = "The Princess Bride";
            princess.Description = "While home sick in bed, a young boy's grandfather reads him a story called The Princess Bride.";
            princess.Pic = "PrincessBride";
            princess.Romance = true;
            princess.Comedy = true;
            princess.Drama = true;

            Movie theGame = new Movie();
            theGame.Name = "The Game";
            theGame.Description = "After a wealthy banker is given an opportunity to participate in a mysterious game, his life is turned upside down when he becomes unable to distinguish between the game and reality.";
            theGame.Pic = "Game";
            theGame.Drama= true;


            Movie saw = new Movie();
            saw.Name = "Saw";
            saw.Description = "Two strangers, who awaken in a room with no recollection of how they got there, soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.";
            saw.Pic = "Saw";
            saw.Horror = true;

            Movie trading = new Movie();
            trading.Name = "Trading Places";
            trading.Description = "A snobbish investor and a wily street con artist find their positions reversed as part of a bet by two callous millionaires.";
            trading.Pic = "Trading";
            trading.Comedy = true;

            Movie sleep = new Movie();
            sleep.Name = "Sleepless in Seattle";
            sleep.Description = "A recently widowed man's son calls a radio talk-show in an attempt to find his father a partner.";
            sleep.Pic = "Sleepless";
            sleep.Romance = true;
            sleep.Drama = true;

            Movie friday = new Movie();
            friday.Name = "Friday the 13th";
            friday.Description = "A group of young adults discover a boarded up Camp Crystal Lake, where they soon encounter Jason Voorhees and his deadly intentions.";
            friday.Pic = "Friday";
            friday.Horror = true;

            Movie showgirls = new Movie();
            showgirls.Name = "Show Girls";
            showgirls.Description = "Nomi, a young drifter, arrives in Las Vegas to become a dancer and soon sets about clawing and pushing her way to become the top of the Vegas showgirls.";
            showgirls.Drama = true;
            showgirls.Pic = "Showgirls";

            Movie slumdog = new Movie();
            slumdog.Name = "Slumdog Millionaire";
            slumdog.Description = "A Mumbai teen reflects on his upbringing in the slums when he is accused of cheating on the Indian Version of 'Who Wants to be a Millionaire?'";
            slumdog.Drama = true;
            slumdog.Pic = "Slumdog";

            Movie chappie = new Movie();
            chappie.Name = "Chappie";
            chappie.Description = "In the near future, crime is patrolled by a mechanized police force. When one police droid, Chappie, is stolen and given new programming, he becomes the first robot with the ability to think and feel for himself.";
            chappie.Drama = true;
            chappie.Pic = "Chappie";

            Movie deathDay = new Movie();
            deathDay.Name = "Happy Death Day";
            deathDay.Description = "A college student must relive the day of her murder over and over again, in a loop that will end only when she discovers her killer's identity.";
            deathDay.Horror = true;
            deathDay.Drama = true;
            deathDay.Pic = "Deathday";

            Movie aboveBelow = new Movie();
            aboveBelow.Name = "As Above, So Below";
            aboveBelow.Description = "When a team of explorers ventures into the catacombs that lie beneath the streets of Paris, they uncover the dark secret that lies within this city of the dead.";
            aboveBelow.Horror = true;
            aboveBelow.Pic = "AboveBelow";

            Movie it = new Movie();
            it.Name = "It";
            it.Description = "In the summer of 1989, a group of bullied kids band together to destroy a shapeshifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.";
            it.Drama = true;
            it.Horror = true;
            it.Pic = "It";

            Movie blended = new Movie();
            blended.Name = "Blended";
            blended.Description = "After a bad blind date, a man and woman find themselves stuck together at a resort for families, where their attraction grows as their respective kids benefit from the burgeoning relationship.";
            blended.Romance = true;
            blended.Comedy = true;
            blended.Pic = "Blended";

            Movie captain = new Movie();
            captain.Name = "Captain Underpants";
            captain.Description = "2 overly imaginative pranksters named George and Harold hypnotize their principal into thinking he's a ridiculously enthusiastic, incredibly dimwitted superhero named Captain Underpants.";
            captain.Comedy = true;
            captain.Pic = "CaptainUnderpants";

            Movie disasterArtist = new Movie();
            disasterArtist.Name = "The Disaster Artist";
            disasterArtist.Description = "When Greg Sestero, an aspiring film actor, meets the weird and mysterious Tommy Wiseau in an acting class, they form a unique friendship and travel to Hollywood to make their dreams come true.";
            disasterArtist.Comedy = true;
            disasterArtist.Drama = true;
            disasterArtist.Pic = "DisasterArtist";

            Movie fistFight = new Movie();
            fistFight.Name = "Fist Fight";
            fistFight.Description = "When one school teacher unwittingly causes another teacher's dismissal, he is challenged to an after-school fight.";
            fistFight.Comedy = true;
            fistFight.Pic = "FistFight";

            Movie meBefore = new Movie();
            meBefore.Name = "Me Before You";
            meBefore.Description = "A girl in a small town forms an unlikely bond with a recently-paralyzed man she's taking care of.";
            meBefore.Romance = true;
            meBefore.Pic = "MeBefore";

            Movie shapeWater = new Movie();
            shapeWater.Name = "The Shape of Water";
            shapeWater.Description = "At a top secret research facility in the 1960s, a lonely janitor forms a unique relationship with an amphibious creature that is being held in captivity.";
            shapeWater.Romance = true;
            shapeWater.Pic = "ShapeWater";

            Movie harrySally = new Movie();
            harrySally.Name = "When Harry met Sally";
            harrySally.Description = "Harry and Sally have known each other for years, and are very good friends, but they fear sex would ruin the friendship.";
            harrySally.Romance = true;
            harrySally.Comedy = true;
            harrySally.Drama = true;
            harrySally.Pic = "HarrySally";

            Movie beauty = new Movie();
            beauty.Name = "Beauty and the Beast";
            beauty.Description = "An adaptation of the fairy tale about a monstrous-looking prince and a young woman who fall in love.";
            beauty.Romance = true;
            beauty.Pic = "Beauty";

            movieList.Add(beauty);
            movieList.Add(harrySally);
            movieList.Add(shapeWater);
            movieList.Add(meBefore);
            movieList.Add(fistFight);
            movieList.Add(disasterArtist);
            movieList.Add(captain);
            movieList.Add(blended);
            movieList.Add(it);
            movieList.Add(aboveBelow);
            movieList.Add(deathDay);
            movieList.Add(chappie);
            movieList.Add(slumdog);
            movieList.Add(showgirls);
            movieList.Add(friday);
            movieList.Add(princess);
            movieList.Add(saw);
            movieList.Add(trading);
            movieList.Add(sleep);
            movieList.Add(theGame);

        }
    }
}
