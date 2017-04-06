namespace Open.Archetypes.ProductClasses
{
    public class ProductInstance : Product<ProductType>
    {
        private string name;
        private string serialNumber;
        private decimal price;
        public string SerialNumber
        {
            get { return SetDefault(ref serialNumber); }
            set { SetValue(ref serialNumber, value); }
        }
        public string Name {
            get { return SetDefault(ref name); }
            set { SetValue(ref name, value); }
        }
        public decimal Price {
            get { return SetDefault(ref price); }
            set { SetValue(ref price, value); }
        }

        //todo: lk7, reservation:ReservationId [0..1]
        //todo: lk7, reserve (reservationId:ReservationId)
        //todo: lk7, cancelReservation()
        //todo: lk7, getReservationStatus():ReservatonStatus
        public override ProductType Type => ProductTypes.Find(TypeId);
        public ProductFeatures Features => ProductFeatures.FindFeatures(UniqueId);
    }
}