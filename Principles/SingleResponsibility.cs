namespace TutorsEquity.Principles
{
    /// <summary>
    /// this is a class having implemented the Single Responsibility Principle in SOLID
    /// </summary>
    class SingleResponsibility
    {
        public static void Main(string[] args)
        {

            //printing the welcome message
            standardmessages.WelcomeMessage();
            person user = new person();


            //receive the first name, validate,
            string fname = receiveinputs.getString("First name");
            if (validateinputs.isvalidString(fname))
            {
                user.FirstName = fname;
            }
            else
            {
                standardmessages.ErrorMessage("first name");
                standardmessages.EndApplication();
            }

            //receive the last name, validate,
            string lname = receiveinputs.getString("Last name");
            if (validateinputs.isvalidString(lname))
            {
                user.LastName = lname;
            }
            else
            {
                standardmessages.ErrorMessage("Last name");
                standardmessages.EndApplication();
            }

            //receive the nationaid, validate,
            int nid = receiveinputs.getint("National Id");
            if (validateinputs.isvalidInt(nid.ToString()))
            {
                user.NationalId = nid;
            }
            else
            {
                standardmessages.ErrorMessage("National Id");
                standardmessages.EndApplication();
            }

            //print the message
            standardmessages.DisplayPerson(user);
        }
    }
}
