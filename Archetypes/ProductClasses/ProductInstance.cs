using Open.Aids;

namespace Open.Archetypes.ProductClasses
{
    public class ProductInstance : ProductType
    {
        private string name;
        private string productType;
        private string price;

        public string Name
        {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }

        public string ProductType
        {
            get { return SetDefault(ref productType); }
            set { SetValue(ref productType, value); }
        }

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