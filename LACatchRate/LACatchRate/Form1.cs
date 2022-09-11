using LACatchRate.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace LACatchRate
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double catchCoef = 0.75f; 
            int pmCatchRate = 0;
            double ballRate = 0;
            int pokeLvl = 0;
            int rank = 0;
            double aiFactor = 0;
            int alpha = 0;
            int outbrake = 0;
            int statused;
            double backstrike;
            double razzBerry;
            string pmName;
            string ballName;
            string pokeLvlNumber;
            string rankNumber;
            string aiFactorNumber;

            
            
            pmName = comboBox1.SelectedItem.ToString();
            ballName = comboBox3.SelectedItem.ToString();
            pokeLvlNumber = comboBox2.SelectedItem.ToString();
            rankNumber = comboBox4.SelectedItem.ToString();
            aiFactorNumber = comboBox5.SelectedItem.ToString();
            
            if (checkBox2.Checked)
            {
                statused = 2;
            }
            else
            {
                statused = 1;
            }

            if (checkBox1.Checked)
            {
                alpha = 4;
            }
            else
            {
                alpha = 0;
            }

            if (checkBox3.Checked)
            {
                backstrike = 1.75f;
            }
            else
            {
                backstrike = 1;
            }

            if (checkBox4.Checked)
            {
                razzBerry = 1.3f;
            }
            else
            {
                razzBerry = 1;
            }

            if (checkBox5.Checked)
            {
                outbrake = 10;
            }
            else
            {
                outbrake = 0;
            }

            switch (pmName)
            {
                case "Pikachu":
                    pmCatchRate = 145;
                    break;
                case "Raichu":
                    pmCatchRate = 95;
                    break;
                case "Clefairy":
                    pmCatchRate = 125;
                    break;
                case "Clefable":
                    pmCatchRate = 75;
                    break;
                case "Vulpix":
                    pmCatchRate = 235;
                    break;
                case "Ninteales":
                    pmCatchRate = 135;
                    break;
                case "Zubat":
                    pmCatchRate = 245;
                    break;
                case "Golbat":
                    pmCatchRate = 145;
                    break;
                case "Paras":
                    pmCatchRate = 235;
                    break;
                case "Parasect":
                    pmCatchRate = 135;

                    break;
                case "Psyduck":
                    pmCatchRate = 235;

                    break;
                case "Golduck":
                    pmCatchRate = 235;

                    break;
                case "Growlithe":
                    pmCatchRate = 235;

                    break;
                case "Arcanine":
                    pmCatchRate = 135;

                    break;
                case "Abra":
                    pmCatchRate = 205;

                    break;
                case "Kadabra":
                    pmCatchRate = 145;

                    break;
                case "Alkazam":
                    pmCatchRate = 95;

                    break;
                case "Machop":
                    pmCatchRate = 245;

                    break;
                case "Machoke":
                    pmCatchRate = 145;

                    break;
                case "Machamp":
                    pmCatchRate = 95;

                    break;
                case "Tentacool":
                    pmCatchRate = 235;

                    break;
                case "Tentacruel":
                    pmCatchRate = 135;

                    break;
                case "Geodude":
                    pmCatchRate = 245;

                    break;
                case "Graveler":
                    pmCatchRate = 145;

                    break;
                case "Golem":
                    pmCatchRate = 95;
                    
                    break;                    
                case "Ponyta":
                    pmCatchRate = 235;

                    break;
                case "Rapidash":
                    pmCatchRate = 135;

                    break;
                case "Magnemite":
                    pmCatchRate = 225;

                    break;
                case "Magneton":
                    pmCatchRate = 125;

                    break;
                case "Gastly":
                    pmCatchRate = 245;

                    break;
                case "Haunter":
                    pmCatchRate = 145;

                    break;
                case "Gengar":
                    pmCatchRate = 95;

                    break;
                case "Onix":
                    pmCatchRate = 235;

                    break;
                case "Voltorb":
                    pmCatchRate = 235;

                    break;
                case "Electrode":
                    pmCatchRate = 135;

                    break;
                case "Lickitung":
                    pmCatchRate = 235;

                    break;
                case "Rhyhom":
                    pmCatchRate = 225;

                    break;
                case "Rhydon":
                    pmCatchRate = 125;

                    break;
                case "Chansey":
                    pmCatchRate = 105;

                    break;
                case "Tangela":
                    pmCatchRate = 235;

                    break;
                case "Mr.MIme":
                    pmCatchRate = 135;

                    break;
                case "Scyther":
                    pmCatchRate = 215;

                    break;
                case "Electabuzz":
                    pmCatchRate = 125;

                    break;
                case "Magmar":
                    pmCatchRate = 125;

                    break;
                case "Magikarp":
                    pmCatchRate = 255;

                    break;
                case "Gyarados":
                    pmCatchRate = 55;

                    break;
                case "Eevee":
                    pmCatchRate = 215;

                    break;
                case "Vaporeon":
                    pmCatchRate = 115;

                    break;
                case "Jolteon":
                    pmCatchRate = 115;

                    break;
                case "Flareon":
                    pmCatchRate = 115;

                    break;
                case "Porygon":
                    pmCatchRate = 205;

                    break;
                case "Snorlax":
                    pmCatchRate = 55;

                    break;
                case "Cyndaquill":
                    pmCatchRate = 205;

                    break;
                case "Quilava":
                    pmCatchRate = 105;

                    break;
                case "Typhlosion":
                    pmCatchRate = 55;

                    break;
                case "Crobat":
                    pmCatchRate = 95;

                    break;
                case "Pichu":
                    pmCatchRate = 245;

                    break;
                case "Cleffa":
                    pmCatchRate = 225;

                    break;
                case "Togepi":
                    pmCatchRate = 205;

                    break;
                case "Togetic":
                    pmCatchRate = 105;

                    break;
                case "Sudowoodo":
                    pmCatchRate = 135;

                    break;
                case "Aipom":
                    pmCatchRate = 235;

                    break;
                case "Yanma":
                    pmCatchRate = 235;

                    break;
                case "Espeon":
                    pmCatchRate = 115;

                    break;
                case "Umbreon":
                    pmCatchRate = 115;

                    break;
                case "Murkow":
                    pmCatchRate = 235;

                    break;
                case "Misdreavus":
                    pmCatchRate = 235;

                    break;
                case "Unown":
                    pmCatchRate = 185;

                    break;
                case "Gligar":
                    pmCatchRate = 235;

                    break;
                case "Steelix":
                    pmCatchRate = 135;

                    break;
                case "Qwilfish":
                    pmCatchRate = 235;

                    break;
                case "Scizor":
                    pmCatchRate = 115;

                    break;
                case "Hearcross":
                    pmCatchRate = 85;

                    break;
                case "Sneasel":
                    pmCatchRate = 235;
                    break;
                case "Teddiursa":
                    pmCatchRate = 225;
                    break;
                case "Ursaring":
                    pmCatchRate = 125;
                    break;
                case "Swinub":
                    pmCatchRate = 225;
                    break;
                case "Piloswine":
                    pmCatchRate = 125;
                    break;
                case "Remoraid":
                    pmCatchRate = 235;
                    break;
                case "Octillery":
                    pmCatchRate = 135;
                    break;
                case "Mantine":
                    pmCatchRate = 135;
                    break;
                case "Porygon2":
                    pmCatchRate = 105;
                    break;
                case "Stantler":
                    pmCatchRate = 235;
                    break;
                case "Elekid":
                    pmCatchRate = 225;
                    break;
                case "Magby":
                    pmCatchRate = 225;
                    break;
                case "Blissey":
                    pmCatchRate = 55;
                    break;
                case "Wurmple":
                    pmCatchRate = 245;
                    break;
                case "Silcoon":
                    pmCatchRate = 195;
                    break;
                case "Beautifly":
                    pmCatchRate = 145;
                    break;
                case "Cascoon":
                    pmCatchRate = 195;
                    break;
                case "Dustox":
                    pmCatchRate = 145;
                    break;
                case "Ralts":
                    pmCatchRate = 225;
                    break;
                case "Kirlia":
                    pmCatchRate = 125;
                    break;
                case "Gardevoir":
                    pmCatchRate = 75;
                    break;
                case "Nosepass":
                    pmCatchRate = 235;
                    break;
                case "Roselia":
                    pmCatchRate = 125;
                    break;
                case "Barboach":
                    pmCatchRate = 235;

                    break;
                case "Whiscah":
                    pmCatchRate = 135;
                    break;
                case "Duskull":
                    pmCatchRate = 225;
                    break;
                case "Dusclops":
                    pmCatchRate = 125;
                    break;
                case "Chimecho":
                    pmCatchRate = 135;

                    break;
                case "Snorunt":
                    pmCatchRate = 235;

                    break;
                case "Glalie":
                    pmCatchRate = 135;

                    break;
                case "Spheal":
                    pmCatchRate = 225;

                    break;
                case "Sealeo":
                    pmCatchRate = 125;

                    break;
                case "Walrein":
                    pmCatchRate = 75;

                    break;
                case "Turtwig":
                    pmCatchRate = 205;

                    break;
                case "Grotle":
                    pmCatchRate = 105;

                    break;
                case "Torterra":
                    pmCatchRate = 55;

                    break;
                case "Chimchar":
                    pmCatchRate = 205;

                    break;
                case "Monferno":
                    pmCatchRate = 105;

                    break;
                case "Infernape":
                    pmCatchRate = 55;

                    break;
                case "Piplup":
                    pmCatchRate = 205;

                    break;
                case "Prinplup":
                    pmCatchRate = 105;

                    break;
                case "Empleon":
                    pmCatchRate = 55;

                    break;
                case "Starly":
                    pmCatchRate = 245;

                    break;
                case "Staravia":
                    pmCatchRate = 145;

                    break;
                case "Staraptor":
                    pmCatchRate = 95;

                    break;
                case "Bidoof":
                    pmCatchRate = 255;

                    break;
                case "Bibarel":
                    pmCatchRate = 155;
                    break;
                case "Kricketot":
                    pmCatchRate = 255;

                    break;
                case "Kricketune":
                    pmCatchRate = 205;

                    break;
                case "Shinx":
                    pmCatchRate = 255;

                    break;
                case "Luxio":
                    pmCatchRate = 125;

                    break;
                case "Luxray":
                    pmCatchRate = 75;

                    break;
                case "Budew":
                    pmCatchRate = 225;

                    break;
                case "Roserade":
                    pmCatchRate = 75;

                    break;
                case "Cranidos":
                    pmCatchRate = 215;

                    break;
                case "Rampardos":
                    pmCatchRate = 115;

                    break;
                case "Shieldon":
                    pmCatchRate = 215;
                    break;
                case "Bastidon":
                    pmCatchRate = 115;
                    break;
                case "Burmy":
                    pmCatchRate = 235;
                    break;
                case "Wormadam":
                    pmCatchRate = 135;
                    break;
                case "Mothim":
                    pmCatchRate = 135;
                    break;
                case "Combee":
                    pmCatchRate = 235;
                    break;
                case "Vespiquen":
                    pmCatchRate = 135;
                    break;
                case "Pachirisu":
                    pmCatchRate = 185;
                    break;
                case "Buizel":
                    pmCatchRate = 235;
                    break;
                case "doublezel":
                    pmCatchRate = 135;
                    break;
                case "Cherubi":
                    pmCatchRate = 235;
                    break;
                case "Cherrim":
                    pmCatchRate = 135;
                    break;
                case "Shellos":
                    pmCatchRate = 235;
                    break;
                case "Gastrodon":
                    pmCatchRate = 135;
                    break;
                case "Ambipom":
                    pmCatchRate = 135;
                    break;
                case "Drifloon":
                    pmCatchRate = 235;
                    break;
                case "Drifblim":
                    pmCatchRate = 135;
                    break;
                case "Buneary":
                    pmCatchRate = 235;
                    break;
                case "Lopunny":
                    pmCatchRate = 135;
                    break;
                case "Mismagius":
                    pmCatchRate = 135;
                    break;
                case "Honchkrow":
                    pmCatchRate = 135;
                    break;
                case "Glameow":
                    pmCatchRate = 255;
                    break;
                case "Purugly":
                    pmCatchRate = 155;
                    break;
                case "Chingling":
                    pmCatchRate = 235;
                    break;
                case "Stunky":
                    pmCatchRate = 235;
                    break;
                case "Skuntank":
                    pmCatchRate = 135;
                    break; 
                case "Bronzor":
                    pmCatchRate = 235;
                    break;
                case "Bronzong":
                    pmCatchRate = 135;
                    break;
                case "Bonsly":
                    pmCatchRate = 235;
                    break;
                case "Mime Jr.":
                    pmCatchRate = 235;
                    break;
                case "Happiny":
                    pmCatchRate = 205;
                    break;
                case "Chatot":
                    pmCatchRate = 125;
                    break;
                case "Spiritomb":
                    pmCatchRate = 65;
                    break; 
                case "Gible":
                    pmCatchRate = 205;
                    break;
                case "Gabite":
                    pmCatchRate = 105;
                    break;
                case "Garchomp":
                    pmCatchRate = 55;
                    break;
                case "Munchlax":
                    pmCatchRate = 255;
                    break;
                case "Riolu":
                    pmCatchRate = 215;
                    break;
                case "Lucario":
                    pmCatchRate = 115;
                    break;
                case "Hippopotas":
                    pmCatchRate = 235;
                    break;
                case "Hippowdon":
                    pmCatchRate = 135;
                    break;
                case "Skorupi":
                    pmCatchRate = 235;
                    break;
                case "Drapion":
                    pmCatchRate = 135;
                    break;
                case "Croagunk":
                    pmCatchRate = 235;
                    break;
                case "Toxicroack":
                    pmCatchRate = 135;
                    break;
                case "Carnivine":
                    pmCatchRate = 185;
                    break;
                case "Finneon":
                    pmCatchRate = 235;
                    break;
                case "Lumineon":
                    pmCatchRate = 135;
                    break;
                case "Mantyke":
                    pmCatchRate = 235;
                    break;
                case "Snover":
                    pmCatchRate = 235;
                    break;
                case "Abomasnow":
                    pmCatchRate = 135;
                    break;
                case "Weavile":
                    pmCatchRate = 135;
                    break;
                case "Magnezone":
                    pmCatchRate = 75;
                    break;
                case "Lickilicly":
                    pmCatchRate = 135;
                    break;
                case "Rhyperior":
                    pmCatchRate = 75;
                    break;
                case "Tangrowth":
                    pmCatchRate = 135;
                    break;
                case "Electivire":
                    pmCatchRate = 75;
                    break;
                case "Magmotar":
                    pmCatchRate = 75;
                    break;
                case "Togekiss":
                    pmCatchRate = 55;
                    break;
                case "Yanmega":
                    pmCatchRate = 135;
                    break;
                case "Leafeon":
                    pmCatchRate = 115;
                    break;
                case "Glaceon":
                    pmCatchRate = 115;
                    break;
                case "Gliscor":
                    pmCatchRate = 135;
                    break;
                case "Mamoswine":
                    pmCatchRate = 75;
                    break;
                case "Porygon-Z":
                    pmCatchRate = 55;
                    break;
                case "Gallade":
                    pmCatchRate = 75;
                    break;
                case "Probopass":
                    pmCatchRate = 135;
                    break;
                case "Dusknoir":
                    pmCatchRate = 75;
                    break;
                case "Froslass":
                    pmCatchRate = 135;
                    break;
                case "Rotom":
                    pmCatchRate = 85;
                    break;
                case "Uxie":
                    pmCatchRate = 45;
                    break;
                case "Mesprit":
                    pmCatchRate = 45;
                    break;
                case "Azelf":
                    pmCatchRate = 45;
                    break;
                case "Dialga":
                    pmCatchRate = 45;
                    break;
                case "Palkia":
                    pmCatchRate = 45;
                    break;
                case "Heatran":
                    pmCatchRate = 45;
                    break;
                case "Regigigas":
                    pmCatchRate = 3;
                    break;
                case "Giratina":
                    pmCatchRate = 45;
                    break;
                case "Cresselia":
                    pmCatchRate = 45;
                    break;
                case "Phione":
                    pmCatchRate = 3;
                    break;
                case "Manaphy":
                    pmCatchRate = 3;
                    break;
                case "Darkai":
                    pmCatchRate = 45;
                    break;
                case "Saymin":
                    pmCatchRate = 3;
                    break;
                case "Arceus":
                    pmCatchRate = 3;
                    break;
                case "Oshawott":
                    pmCatchRate = 205;
                    break;
                case "Dewott":
                    pmCatchRate = 105;
                    break;
                case "Samurott":
                    pmCatchRate = 55;
                    break;
                case "Petilil":
                    pmCatchRate = 235;
                    break;
                case "Lilligant":
                    pmCatchRate = 135;
                    break;
                case "Basculin":
                    pmCatchRate = 235;
                    break;
                case "Zorua":
                    pmCatchRate = 215;
                    break;
                case "Zoroark":
                    pmCatchRate = 115;
                    break;
                case "Rufflet":
                    pmCatchRate = 235;
                    break;
                case "Braviary":
                    pmCatchRate = 135;
                    break;
                case "Tornadus":
                    pmCatchRate = 3;
                    break;
                case "Thundurus":
                    pmCatchRate = 3;
                    break;
                case "Landorus":
                    pmCatchRate = 3;
                    break;
                case "Sylveon":
                    pmCatchRate = 115;
                    break;
                case "Goomy":
                    pmCatchRate = 205;
                    break;
                case "Sliggoo":
                    pmCatchRate = 105;
                    break;
                case "Goodra":
                    pmCatchRate = 55;
                    break;
                case "Bergmite":
                    pmCatchRate = 235;
                    break;
                case "Avalugg":
                    pmCatchRate = 135;
                    break;
                case "Rowlet":
                    pmCatchRate = 205;
                    break;
                case "Dartrix":
                    pmCatchRate = 105;
                    break;
                case "Decidueye":
                    pmCatchRate = 55;
                    break;
                case "Wyrdeer":
                    pmCatchRate = 135;
                    break;
                case "Kleavor":
                    pmCatchRate = 115;
                    break;
                case "Ursaluna":
                    pmCatchRate = 75;
                    break;
                case "Basculegion":
                    pmCatchRate = 135;
                    break;
                case "Sneasler":
                    pmCatchRate = 135;
                    break;
                case "Overqwil":
                    pmCatchRate = 135;
                    break;
                case "Enamorus":
                    pmCatchRate = 3;
                    break;

            }

            switch (ballName)
            {
                case "Poke Ball":
                    ballRate = 0.75f;
                    break;
                case "Great Ball":
                    ballRate = 1.5f;
                    break;
                case "Ultra Ball":
                    ballRate = 2.25f;
                    break;
                case "Feather Ball":
                    if (checkBox6.Checked)
                    {
                        ballRate = 1.25f;
                    }
                    else
                    {
                        ballRate = 0.5f;
                    }
                    break;
                case "Wing Ball":
                    if (checkBox6.Checked)
                    {
                        ballRate = 2f;
                    }
                    else
                    {
                        ballRate = 1.25f;
                    }
                    break;
                case "Jet Ball":
                    if (checkBox6.Checked)
                    {
                        ballRate = 2.75f;
                    }
                    else
                    {
                        ballRate = 2f;
                    }
                    break;
                case "Heavy Ball":
                    if (checkBox6.Checked)
                    {
                        ballRate = 1.25f;
                    }
                    else
                    {
                        ballRate = 1f;
                    }
                    break;
                case "Leaden Ball":
                    if (checkBox6.Checked)
                    {
                        ballRate = 2f;
                    }
                    else
                    {
                        ballRate = 1.75f;
                    }
                    break;
                case "Gigaton Ball":
                    if (checkBox6.Checked)
                    {
                        ballRate = 2.75f;
                    }
                    else
                    {
                        ballRate = 2.5f;
                    }
                    break;
            }
            switch (pokeLvlNumber)
            {
                case "1-10":
                    pokeLvl = 1;
                    break;
                case "11-20":
                    pokeLvl = 2;
                    break;
                case "21-30":
                    pokeLvl = 3;
                    break;
                case "31-40":
                    pokeLvl = 4;
                    break;
                case "41-50":
                    pokeLvl = 5;
                    break;
                case "51-60":
                    pokeLvl = 6;
                    break;
                case "61-70":
                    pokeLvl = 7;
                    break;
                case "71-80":
                    pokeLvl = 8;
                    break;
                case "81-90":
                    pokeLvl = 9;
                    break;
                case "91-100":
                    pokeLvl = 10;
                    break;
            }
            switch (rankNumber)
            {
                case "1":
                    rank = 1;
                    break;
                case "2":
                    rank = 2;
                    break;
                case "3":
                    rank = 3;
                    break;
                case "4":
                    rank = 4;
                    break;
                case "5":
                    rank = 5;
                    break;
                case "6":
                    rank = 6;
                    break;
                case "7":
                    rank = 7;
                    break;
                case "8": 
                    rank = 8; 
                    break;
                case "9":
                    rank = 9;
                    break;
                case "10":
                    rank = 10;
                    break;
            }
            switch (aiFactorNumber)
            {
                case "Pokemon left alone in battle":
                    aiFactor = 2;
                    break;
                case "! sign is appeared":
                    aiFactor = 1;
                    break;
                case "Aggresive Pokemon notice you, but not target you":
                    aiFactor = 1;
                    break;
                case "... sign appeared":
                    aiFactor = 2;
                    break;
                case "Pokemon eating anything":
                    aiFactor = 2.5f;
                    break;
                case "Pokemon eating berry":
                    aiFactor = 2.5f;
                    break;
                case "Pokemon eating cake":
                    aiFactor = 4;
                    break;
                case "Pokemon snoring":
                    aiFactor = 4;
                    break;
                case "Pokemon stunned with item":
                    aiFactor = 3;
                    break;
                case "Pokemon seating, but not sleep":
                    aiFactor = 2.5f;
                    break;
                case "Pokemon running away":
                    aiFactor = 1;
                    break;
            }

            
            int maxHp = Convert.ToInt32(textBox1.Text);
            int curHp = Convert.ToInt32(textBox2.Text);

            double catchRateFactor = (catchCoef * pmCatchRate) + outbrake;
            double lvFactor = rank - (alpha + pokeLvl) + 1;
            double rankFactor = 30 * lvFactor;
            double resc17 = catchRateFactor + rankFactor;
            double hpFactor = 1 - ((0.66f * curHp) / maxHp);
            double envFactor = (((((30 * hpFactor) * statused) * ballRate) * aiFactor) * backstrike) * razzBerry;
            double captureIndicator = envFactor + resc17;
            double fmax = Math.Max(captureIndicator / 255, 0);
            double fmin = Math.Min(fmax, 1);
            double v94 = 0.5f;
            double v96 = Math.Pow((1 - fmin), v94);
            double shakeChance = (1 - v96) * 65535;

            double chanceSimple = shakeChance / 65536;
            double chanceFancy = (65536 - shakeChance) / 65536 * chanceSimple;
            double result = chanceFancy + chanceSimple;

            double simpleTb = chanceSimple * 100;
            double fancyTb = chanceFancy * 100;
            double resTb = simpleTb + fancyTb;

            textBox3.Text = Convert.ToString(simpleTb);
            textBox4.Text = Convert.ToString(fancyTb);
            textBox5.Text = Convert.ToString(resTb);



        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch2 = e.KeyChar;
            if (!Char.IsDigit(ch2))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thx Anubis for info about formulas. His page on twitter: @Sibuna_Switch", "About");
            MessageBox.Show("My Discord: Ja'Khajiit#5888", "About");
            
            
        }
    }
}
