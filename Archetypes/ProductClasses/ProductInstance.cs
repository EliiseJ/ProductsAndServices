using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.ProductClasses
{
    public class ProductInstance : Archetype
    {
        private string productId;

        public string ProductId
        {
            get { return SetDefault(ref productId); }
            set { SetValue(ref productId, value); }
        }
        private string productInstanceId;
        public string ProductInstanceId
        {
            get { return SetDefault(ref productInstanceId); }
            set { SetValue(ref productInstanceId, value); }
        }
        private string name;
        private string productType;
        private string price;

        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public  ProductType ProductType => ProductTypes.Find(ProductInstanceId);

        public string Price
        {
            get { return SetDefault(ref price); }
            set { SetValue(ref price, value); }
        }
        

        //todo: lk7, reservation:ReservationId [0..1]
        //todo: lk7, reserve (reservationId:ReservationId)
        //todo: lk7, cancelReservation()
        //todo: lk7, getReservationStatus():ReservatonStatus
    }
}