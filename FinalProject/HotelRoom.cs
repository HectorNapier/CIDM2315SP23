class HotelRoom{
    //public string price {get;set;} = 0;
    public string roomNumber {get;set;} = "0"; 
    public int capacity {get;set;} = 0;
    public bool isReserved {get;set;} = false;
    public string guestName {get;set;} = "";
    public string guestEmail {get;set;} = "";

    public HotelRoom(string roomNumber, int capacity){
        this.roomNumber=roomNumber;
        this.capacity=capacity;

    }

}