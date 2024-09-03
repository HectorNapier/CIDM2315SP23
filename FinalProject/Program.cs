namespace FinalProject;
class Program
{

    static void Main(string[] args)
    {
        string user = employee_login();
        List<HotelRoom> room_info =create_room_info();
        string choice = "";
        while (choice != "5"){
            print_menu();

            choice = Console.ReadLine();

            if(choice=="1"){
                print_room_info(room_info);
            }
            else if(choice == "2"){
                int availableRooms = print_available_rooms(room_info); 
                if(availableRooms > 0){
                    reserve_room(room_info); 
                }else{
                    Console.WriteLine("No suitable room at this time.");
                }
                
            }
            else if(choice =="3"){
                print_reserved_room_info(room_info);

            }
            else if(choice == "4"){
                checkout(room_info);
            }
            else if(choice == "5"){
                signOut();
            }
            else{
                Console.WriteLine("Option Does Not Exist");
            }

        }

    }
    public static string employee_login(){

        Dictionary<string, string> dict_login = new Dictionary<string, string>(); //Dictionary Used to store User & Password.
        dict_login.Add("alice","alice123"); //Store user & Password.
        //Intro 
        Console.WriteLine("-----CIDM2315 Final Project: Hector Napier------");
        Console.WriteLine("-----Welcome to Buff Hotel------");
        //Ask user info and store their answer in "user" and "password"
        Console.WriteLine("--> Please input username");
        string user = Console.ReadLine();
        if ( dict_login.ContainsKey(user) == false){
            Console.WriteLine("User not found");
            
            System.Environment.Exit(1);
        }

        Console.WriteLine("--> Please input password");
        string password = Console.ReadLine();
        string passwordForUser = dict_login[user];
        if ( password != passwordForUser){
            Console.WriteLine("Wrong Password!");

            System.Environment.Exit(1);
        }
        
        Console.WriteLine("--> Log in successfully!");
        Console.WriteLine(" ** Hello User : " + user + " **");
        return user;
        
    }
    public static void print_menu(){
        Console.WriteLine("*******************");
        Console.WriteLine("Please select: ");
        Console.WriteLine("1. Show Available Rooms");
        Console.WriteLine("2. Check-In");
        Console.WriteLine("3. Show Reserved Room");
        Console.WriteLine("4. Check-Out");
        Console.WriteLine("5. Log Out");
        Console.WriteLine("*******************");
     }
    public static List<HotelRoom> create_room_info(){
        List<HotelRoom> rooms = new List<HotelRoom>();
        rooms.Add(new HotelRoom(roomNumber:"101", capacity: 2 ));
        rooms.Add(new HotelRoom(roomNumber:"102", capacity: 2 ));
        rooms.Add(new HotelRoom(roomNumber:"103", capacity: 2 ));
        rooms.Add(new HotelRoom(roomNumber:"104", capacity: 2 ));
        rooms.Add(new HotelRoom(roomNumber:"105", capacity: 2 ));
        rooms.Add(new HotelRoom(roomNumber:"106", capacity: 3 ));
        rooms.Add(new HotelRoom(roomNumber:"107", capacity: 3 ));
        rooms.Add(new HotelRoom(roomNumber:"108", capacity: 3 ));
        rooms.Add(new HotelRoom(roomNumber:"109", capacity: 3 ));
        rooms.Add(new HotelRoom(roomNumber:"110", capacity: 4 ));
        return rooms;

     }
     
    public static void print_room_info(List<HotelRoom> room_info) {
         int isAvailable = 0;
        foreach (var room in room_info) {
            if(room.isReserved==false){
                isAvailable +=1;
                int capacity = room.capacity; 
                string room_number = room.roomNumber;
                Console.WriteLine("+ Room Number: {0} ;  Capacity {1}", room_number, capacity);
            }
            
        }
        
        Console.WriteLine("------ Number of Available Rooms:" + isAvailable + "------");

     }
    public static int print_available_rooms(List<HotelRoom>  room_info) { 

        Console.WriteLine("Input Number of People");
        int group_size = Convert.ToInt32(Console.ReadLine());
        int notAvailable = 0;
        foreach (var room in room_info) {
            int capacity = room.capacity;
            string room_number = room.roomNumber;  
            bool isReserved=room.isReserved;  
             if (capacity >= group_size && isReserved == false){
                    Console.WriteLine("+ Room Number: {0} ;  Capacity {1}", room_number, capacity);
            }else{
                notAvailable = notAvailable + 1;
            }
        }
            
        if (notAvailable == room_info.Count){
            Console.WriteLine("------ Number of Available Rooms:  0  ------"); 

        }else{
            Console.WriteLine("------ Number of Available Rooms:" + (room_info.Count - notAvailable) + "------");
        }
        return room_info.Count - notAvailable;
     }
    public static void reserve_room(List<HotelRoom> room_info){ //defined method
        Console.WriteLine("Input Room Number:");
        string room_number = Console.ReadLine();

        Console.WriteLine("Input Customer Name:");
        string customer_name = Console.ReadLine();
        
        Console.WriteLine("Input Customer Email :");
        string customer_email = Console.ReadLine();
        
        foreach (var room in room_info) {
            string roomNum = room.roomNumber;
            if(roomNum == room_number){
                room.guestName = customer_name;
                room.guestEmail = customer_email;
                room.isReserved = true;
            }
        }

        Console.WriteLine("--> Check-In successfully! Customer is assigned to Room " + room_number);
     }
    public static void print_reserved_room_info(List<HotelRoom> room_info) {
        foreach (var room in room_info) {
            if(room.isReserved==true){
                string name = room.guestName; 
                string room_number = room.roomNumber;
                Console.WriteLine("+ Room Number: {0} ;  Customer {1}", room_number, name);
            }   
        }
     }
    public static void checkout(List<HotelRoom> room_info) {
        Console.WriteLine("Input Room Number:");
        string room_number = Console.ReadLine();
        foreach (var room in room_info) {
            string roomNum = room.roomNumber;
            if(roomNum == room_number){
               string name =  room.guestName;
               if(room.isReserved==false){
                Console.WriteLine("Could not find customer record of this room.");
               }else{      
                Console.WriteLine("+ Room Number: {0} ;  Customer {1}", room_number, name);
                Console.WriteLine("--->Please confirm the customer name and input y to continue Check-Out OR input any key to cancel.");
                string response = Console.ReadLine();
                if(response == "y"){
                    room.isReserved = false;
                    room.guestName = "";
                    room.guestEmail = "";
                    Console.WriteLine("Checked-Out Successfully");
                }else{
                    Console.WriteLine("Check-Out Canceled");
                }
               }
            }
            
        }
     }
    public static void signOut(){
        Console.WriteLine("--> Log out system");
    }

    
}
