using Car_E_shop.Models;

namespace Car_E_shop.Interfaces
{
    public interface IRepoCar
    {
        public string SaveCar(Car car);

        public Car GetCarById(int carId);

        public Car GetCarByYear(DateTime year);
        
        public Car GetCarByName(string carName);

        public Car GetCarOwner(int carId);

        public Car SetPrice(int carId, double price);

        public Car SetProducerName(int carId, string producerName);

        public Car SetCarMake(int carId, string producerName);
        
        public Car SetYearOfProdcutin(int carId, DateTime year);
        
        public Car SetCarOwner(int carId, User owner);

        public Car SetCarType(int carId, string type);

    }
}
