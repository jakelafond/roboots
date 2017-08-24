using System;
using System.Collections.Generic;

namespace roboots
{
    class RobotModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string University { get; set; }
        public string Job { get; set; }
        public string Company { get; set; }
        public List<string> Skills { get; set; }
        public string Phone { get; set; }
        public Dictionary<string,string> Address { get; set; }
        

        //example robot 
    // "id": 1,
	// "username": "hjuza0",
	// "name": "Hamlen Juza",
	// "avatar": "https://robohash.org/blanditiisexercitationemquaerat.png?size=150x150&set=set1",
	// "email": "hjuza0@blogger.com",
	// "university": "Pomor State University",
	// "job": "Engineer IV",
	// "company": "Stark, Feil and Bode",
	// "skills": ["DMVPN", "HDX", "Rhino 3D"],
	// "phone": "7-(397)813-7803",
	// "address": {
	// 	"street_num": "78226",
	// 	"street_name": "Ryan",
	// 	"city": "Kamennogorsk",
	// 	"state_or_province": null,
	// 	"postal_code": "188950",
	// 	"country": "Russia"
        
    }
    
}