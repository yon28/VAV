namespace Task2
{
    public class Office
    {
        Person.ECome Come;
        Person.ELeft Left;
        public void AddUser(Person user)
        {
            if (user != null)
            {
                Come?.Invoke(user, user.Arrival);
            }
            Come += user.SayHi;
            Left += user.SayGoodbye;
        }
        public void LeftUser(Person user)
        {
            Come -= user.SayHi;
            Left -= user.SayGoodbye;
            if (user != null)
            {
                Left?.Invoke(user);
            }
        }
    }
}
