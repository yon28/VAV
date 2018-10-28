namespace Task2
{
    public class Office
    {
        EventArgs.ECome Come;
        EventArgs.ELeft Left;
        public void AddUser(EventArgs user)
        {
            if (user != null)
            {
                Come?.Invoke(user, user.Arrival);
            }
            Come += user.SayHi;
            Left += user.SayGoodbye;
        }
        public void LeftUser(EventArgs user)
        {
            Left -= user.SayGoodbye;
            if (user != null)
            {
                Left?.Invoke(user);
            }
        }
    }
}
