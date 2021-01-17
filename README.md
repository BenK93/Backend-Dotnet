# Backend .NET Token authentication


### Start project

# Project API

POST [http://localhost:5000/5001](http://localhost:5000/5001)
- BODY => `{ email: "example@gmail.com" , password: "yourPassword"}`

### Response 
![Screen Shot 2021-01-15 at 13 11 53](https://user-images.githubusercontent.com/21170255/104839899-e4caca00-58cc-11eb-95ca-dc538139157f.jpg)

GET [http://localhost:5000/5001/info](http://localhost:5000/5001/info)
-> Header => `{Token : "yourToken"}`

### Response 
![Screen Shot 2021-01-16 at 14 26 49](https://user-images.githubusercontent.com/21170255/104839889-d4b2ea80-58cc-11eb-8d87-760155fc4f88.jpg)
