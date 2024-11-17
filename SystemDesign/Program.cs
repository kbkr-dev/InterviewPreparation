using SystemDesign.AbstractFactoryPattern;
using SystemDesign.DecoratorPattern;
using SystemDesign.FactoryPattern;
using SystemDesign.ObserverPattern;

namespace SystemDesign
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Observer Pattern

            // Observer pattern
            //AmazonObserver amazonObserver = new AmazonObserver();
            //AmazonObservable amazonObservable = new AmazonObservable();
            //amazonObservable.Attach(amazonObserver);
            //amazonObservable.SetData(2);

            #endregion

            #region Observer pattern using Event
            // creating publisher
            //NotificationService notificationService = new NotificationService("Iphone", "Available");

            //// Create subscribers
            //Observer amazonObserver = new Observer("Amazon");
            //Observer flipkartObserver = new Observer("Flipkart");

            //// Subscribe observers to the event
            //notificationService.onPushNotification += amazonObserver.ReceivedNotification;
            //notificationService.onPushNotification += flipkartObserver.ReceivedNotification;

            //// Trigger notifications
            //notificationService.SetTitle("Iphone 15");
            //notificationService.onPushNotification -= flipkartObserver.ReceivedNotification;
            //notificationService.SetTitle("Letv Phone");

            #endregion

            #region Observer pattern using Delegate
            // creating publisher
            //NotificationDelegateService delegateService = new NotificationDelegateService("Iphone", "Available");

            //// Create subscribers
            //Observer amazonObserver = new Observer("Amazon");
            //Observer flipkartObserver = new Observer("Flipkart");

            //// Subscribe observers to the event
            //delegateService.NotifyObservers += amazonObserver.ReceivedDelegateNotification;
            //delegateService.NotifyObservers += flipkartObserver.ReceivedDelegateNotification;

            //// Trigger notifications
            //delegateService.SetTitle("Iphone 15");
            //delegateService.NotifyObservers -= flipkartObserver.ReceivedDelegateNotification;
            //delegateService.SetTitle("Letv Phone");

            #endregion

            #region Decorator pattern with coffee shop example
            //ICoffeeShop coffeeShop = new RegularCoffee();
            //coffeeShop = new MilkDecorator(coffeeShop);
            //coffeeShop = new SugarDecorator(coffeeShop);
            //Console.WriteLine($"Description is {coffeeShop.GetDescription()} and price is {coffeeShop.GetPrice()}");

            #endregion

            #region Factory Pattern with vehicle factory example

            //IVehicle vehicle = VehicleFactory.CreateVehicle("bike");
            //Console.WriteLine(vehicle.Drive()+" with tyres "+ vehicle.GetTyres());

            #endregion

            #region 

            VehicleAbstractFactory bikeFactory = new BajajFactory();
            IBike bike = bikeFactory.CreateBike();
            bike.Drive();

            #endregion

            Console.ReadKey();
        }
    }
}
