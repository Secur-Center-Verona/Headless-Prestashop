using PrestashopHeadlessMiddleware.Accounts;
using PrestashopHeadlessMiddleware.Carts;
using PrestashopHeadlessMiddleware.Categories;
using PrestashopHeadlessMiddleware.Orders;
using PrestashopHeadlessMiddleware.Products;

namespace PrestashopHeadlessMiddleware
{
    public static class PrestashopMiddleware
    {
        private static string _connectionString;

        public static AccountsService AccountsService { get; private set; }
        public static CartsService CartsService { get; private set; }
        public static CategoriesService CategoriesService { get; private set; }
        public static OrdersService OrdersService { get; private set; }
        public static ProductsService ProductsService { get; private set; }

        public static void Initialize(string databaseHost, string databasePort, string user, string password, string databaseName)
        {
            _connectionString = $"server={databaseHost}:{databasePort};user id={user};password={password};Convert Zero Datetime=True;persistsecurityinfo=True;database={databaseName}";

            AccountsService = new AccountsService(_connectionString);
            CartsService = new CartsService();
            CategoriesService = new CategoriesService();
            OrdersService = new OrdersService();
            ProductsService = new ProductsService();
        }
    }
}