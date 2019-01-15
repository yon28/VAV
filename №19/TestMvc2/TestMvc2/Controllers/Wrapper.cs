using Department.BLL;

namespace TestMvc2.Controllers
{
    static class Wrapper
    {
        public static EmployeesBL employeesBL = new EmployeesBL();
        public static RewardsBL rewardsBL = new RewardsBL();
        static Wrapper()
        {
            rewardsBL.InitList();
            employeesBL.InitList();
        }
    }
}