using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayfairDecoder
{
    public class Program
    {
        public int maxScore;

        static void Main(string[] args)
        {
            qgr qgr = new qgr();
            char[] cipherText = "YCAHFUECQIYSAYAQVYOXAYYOCGOHXKDTQXCXSOWSXKXFTBPRFDVDUOYXUDNAIXFQUDIRSOBGYIUTAYMDVOYVSOTBPRFDRSXTTDVUHTXQHAXFFBCYPQUHBUDNNFMDEBGSUMZNQIOHCDNDYIDYOYHCQFYZDYDHUTAVYAHTHCFNAXBKQNAGDNYUCQUTSQORBFKCUMVNOYULDMMAKUUKYRXSGSDATDRSFEXUEXRHFNUDYOXKXRRSYIQURFDYNRYARYANFQGOCXUDEGFUXFYRSTGBVAHCFXORHCKUDICHAQHCKPYCRCUDGMZLDANRYACYUKQNSODAXEBRLQMDYNXFDMGNYOXUXLECFQYXHCXEFBIXAVFDUBRSXTTDRSOHBQNGSOTBPRFDGBUBDZZEQUPXTBPRFDBUDNNFMDEBBHAVFDENECCZYIUDDZPFGUXEBTLQHVORRCSOOYKRGBMSGBHRSUROYNXUDFDYDYIDRYYOPKGSBFCIQFFUZYYIULQAXFRSXTTDYAKUYARYNXOYHCFNUDNKTAEABGYIFDIDBZYGSOXCSOUKRSXTTDULDYWGCYECEBYNFXSDLNHRSOFIMXYQDNQXXKZDYDOHTDZGHCUDXUXBUKOYDAXFOHCGPZKURSECCIFNCDZYYITBPRFDBUITAVFDXQDPZCKUATBSULQAXFNDBUEUMUADCYYIOYHCKUDRQFBTORYBGPKXOMXEZBLQYAOXQATDSOYAOVSOEGSVTSVHAYCDPQTBPRFDYCSFLNHCFUGHFNNPBCQPFXYUPEBQYCQFGNYOEGSVTSVHUTAQTBAXUKDCANNGPKECFLYUKSSVOYMAYZKUZEOXXQXFNAIXFQPQXDUYYAOQFXITFQPQTAQDSOTBPRFDBGXRAVFDPQTDBCQPFXYACYEXHAUYBFQIVSBEIAXNHTXQCFIODFASBVFQIADOECQCTSUKAOHTOYGUUDGFYUABTBPRFDBUDNNFMDEBAGYOXKMSBHFQDAQINPNFXHXKDZMXKUBGUYHCORXKMSAKFBHTXQCDYIPQXDUYNAHAFQITAVFDKSSVUBZYBGICIQSBDYIHUYLDNFIXLNYXXKZEUDZGHCQPFXGVATNRNFMDEBUHUWSQFNYORBYXQPXPMAYZLXAVFDXKPAHTXQXFNAYNFXCGBAXFORCRAVFDCGAWOBRORCFXNZZEDYIDYNDIDUYXQITBPRFDAORQATXODUXQQIPXYCXKAMFNBFOBYUXCKUCYUBXUFPFNOYXKDACGFMYOVYBXAVFDRSXTTDTBPRFDNFMDEBBHUYCYPNFNTBPRFDZGECKZBDHCFXQEATVYAXNSDANRYAHTHCFXKXUBULXPBFYCCQLXRSYILNYXXKDAADYIFPXPHOKSORNGSOPFUDBUDNRSXTTDORUYXLYACYHCSOWSRVDMQNKPUBYSDYYHBTAVFUYNROLQPFOIBGNFBFUYDSEUMUCDCYUYRBYXYAYCTBPRFDBUDNXKOHDBXQHAQFITAVFDFDNFNQZGECFQUEFBDYYAHTHCFNAXBKQNBHAVFDKSSTDMCZOHXPFNOYBFQBQRCGGKYCCKUTSQBSEAHTXQCDIXAVMXKXXPBGUYUYHCLNARBRKUTBPRFDNBPVFNUBBFSOYMBYXLBHXFLXXKIRAVFDXSXTTDNERSXTTDQBSQFNBFFBTANPYRXKTAAVULQAXFXFBFZLDYYHXKQYZBKXDMGBBOFNRAAVNFMDEBUHUWBTLQHVORRCYAOTBNXQCDWSHRAVFDPKXFUVFXORDYYHSUPQTDCYWSHORCFNBELXAVFDBUDNNFMDEBBHAVFDYUNRNDYIORCGGKORRCUDYRBXLGYIYCAUHLDYOYCGGKBDOHTBORYAHVFUXFORXQPVCYYIOYCYPFVYAXNFMUXHAXQETAVRXKTSOBKPYCTGSOARDFZCGONDBUEUMUCDCYUYTBPRFDRSXTTDHCOBHCLXRSAFACFUHGHCFPAVXPOVSOBFKCFUMRATBUEQOVYAHCQXAXPXYRYOXKNAHAFQGOTBPRFDPKECCBAVFDDAKPFUECEZBRLQMDYNXFDMVOSYUYUYQUQRXKFDGUPKXFGRDZYAXOIXFQPQXDUYMSUHOHZCKBROCDYIUMMUECFQMDHTHCLUBENKDYNFMDEBUHGKBDOHTBORVUHLQXYAXVFXRSWUPKGSSOFIMSYCSOHODNLNYXXKRSECCBAVFDNFMDEBBHAVFDPAAFAXFNXKOHDBYAHOXKBCFUCFDQQFHTHCORYCVSBEIAQXBRCQKUAKATHCFPOYXFFDDYHCFXUTAVKSZCKXDATDUDYRXKNAHAFQGOXURCUDNKIFYQDYIHAVFDVUUHBGICVOFUARBERDXFPKECKBYAHTHCFXKUYUPXFNTBPRFDRSXTTDPAHTXQXFIRAVFDAOXOIXFQPQXDUYFDNFUDDQAXHCFXXUZEUDORYBPNPUPXXLUHBUTDOIBUGDYIQBANQITBPRFDPKECCBAVFDHCGBGBYSAYOILXAVFDHCXPTBPRFDASGNYOXKGKNPWSGBCDWSROAFNEMSAMOYGSSFKXDATDGSUDIRAVFDAOROHTHCQFUBRVAVXPHOXUFPFNNPUAFQOYRDXLYCTBPRFDUDMFFXQFITQBUKGRGBLDOHUDIAKNUDGKDYIDYIYCAUHLMSAMUDMRATMSAMCZLQDFQXTAYUPF".ToArray();
            char[] plainText = new char[cipherText.Length];
            char[] key = "RXTHCAUOSBDNYGIMPVWZFEQKL".ToArray();
            int i = 0;
            double score, maxscore = -99e99;

            while (true)
            {
                Console.WriteLine("Beginning iteration");
                i++;
                score = playfairCrack(cipherText, ref key);
                if(score > maxscore)
                {
                    maxscore = score;
                    Console.WriteLine("best score so far: " + score);
                    Console.WriteLine("Iteration: " + i);
                    Console.Write("Key: '");
                    for (int j = 0; j < key.Length; j++)
                    {
                        Console.Write(key[j]);
                    }
                    Console.WriteLine("\n");
                    plainText = playfairDecipher(key, cipherText);
                    Console.Write("plaintext: '");
                    for (int j = 0; j < plainText.Length; j++)
                    {
                        Console.Write(plainText[j]);
                    }
                    Console.Write("'\n");
                }
            }
        }

        static char[] swapTwoKeyLetters(char[] key)
        {
            Random rand = new Random();
            int i = rand.Next() % 25;
            int j = rand.Next() % 25;
            char temp = key[i];
            key[i] = key[j];
            key[j] = temp;
            return key;
        }

        static char[] swapTwoKeyRows(char[] key)
        {
            Random rand = new Random();
            int i = rand.Next() % 5;
            int j = rand.Next() % 5;
            char temp;
            for (int k = 0; k < 5; k++)
            {
                temp = key[i * 5 + k];
                key[i * 5 + k] = key[j * 5 + k];
                key[j * 5 + k] = temp;
            }
            return key;
        }

        static char[] swapTwoKeyColumns(char[] key)
        {
            Random rand = new Random();
            int i = rand.Next() % 5;
            int j = rand.Next() % 5;
            char temp;
            for(int k = 0; k < 5; k++)
            {
                temp = key[k * 5 + i];
                key[k * 5 + i] = key[k * 5 + j];
                key[k * 5 + j] = temp;
            }
            return key;
        }

        static char[] modifyKey(char[] oldKey)
        {
            Random rand = new Random();
            char[] newKey = oldKey;
            int i = rand.Next() % 50;
            switch (i){
                case 0:
                    newKey = swapTwoKeyRows(oldKey);
                    break;
                case 1:
                    swapTwoKeyColumns(oldKey);
                    break;
                //case 2:
                //    newKey = oldKey.Reverse();
                //    break;
                default:
                    swapTwoKeyLetters(oldKey);
                    break;
            }
            return newKey;
        }

        static private float playfairCrack(char[] text, ref char[] key)
        {
            qgr qgr = new qgr();
            Random rand = new Random();
            float bestScore = 0F;
            char[] deciphered;
            char[] testKey = key;
            char[] maxKey = key;
            double prob, dF, maxScore, score;
            deciphered = playfairDecipher(testKey, text);
            maxScore = qgr.scoreTextQgram(deciphered);
            bestScore = (float)maxScore;

            for (float T = 20; T >= 0; T -= 0.2F)
            {
                for (int count = 0; count < 5000; count++)
                {
                    testKey = modifyKey(maxKey);
                    deciphered = playfairDecipher(testKey, text);
                    score = qgr.scoreTextQgram(deciphered);
                    dF = score - maxScore;
                    if(dF >= 0)
                    {
                        maxScore = score;
                        testKey = maxKey;
                    }
                    else if (T > 0)
                    {
                        prob = Math.Exp(dF / T);
                        if (prob > 1.0 * rand.Next() / 2147483647)
                        {
                            maxScore = score;
                            testKey = maxKey;
                        }
                    }

                    if(maxScore > bestScore)
                    {
                        bestScore = (float)maxScore;
                        key = maxKey;
                    }
                }
            }

            return bestScore;
        }

        static private char[] playfairDecipher(char[] key, char[] text)
        {
            char[] result = text;
            char a, b;
            int a_ind, b_ind, a_row, b_row, a_col, b_col;

            for (int i = 0; i < text.Length; i += 2)
            {
                a = text[i];
                b = text[i + 1];
                a_ind = Array.IndexOf(key, a);
                b_ind = Array.IndexOf(key, b);
                a_row = a_ind / 5;
                b_row = b_ind / 5;
                a_col = a_ind % 5;
                b_col = b_ind % 5;
                if (a_row == b_row)
                {
                    if(a_col == 0)
                    {
                        result[i] = key[a_ind + 4];
                        result[i + 1] = key[b_ind - 1];
                    }
                    else if(b_col == 0)
                    {
                        result[i] = key[a_ind - 1];
                        result[i + 1] = key[b_ind + 4];
                    }
                    else
                    {
                        result[i] = key[a_ind - 1];
                        result[i + 1] = key[b_ind - 1];
                    }
                }
                else if(a_col == b_col)
                {
                    if(a_row == 0)
                    {
                        result[i] = key[a_ind + 20];
                        result[i + 1] = key[b_ind - 5];
                    }
                    else if(b_row == 0)
                    {
                        result[i] = key[a_ind - 5];
                        result[i + 1] = key[b_ind + 20];
                    }
                    else
                    {
                        result[i] = key[a_ind - 5];
                        result[i + 1] = key[b_ind - 5];
                    }
                }
                else
                {
                    result[i] = key[5 * a_row + b_col];
                    result[i + 1] = key[5 * b_row + a_col];
                }
            }
            return result;
        }
    }
}
