namespace SingleResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myJournal = new Journal();

            //add entries
            myJournal.AddEntry("I woke up");
            myJournal.AddEntry("I walked");
            myJournal.AddEntry("I slept off");

            //remove entry
            myJournal.RemoveEntry(2);

            //We want to print something to the file
            //This if added to the Journal will break Single responisibility principle
            //Hence we create a new class for printing

            SavingData.SaveToFile(myJournal);

        }
    }
}