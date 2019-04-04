import { Component, OnInit } from "@angular/core";
import { Observable } from "rxjs/Rx";
import { User } from "./user";
import { UserService } from "./userService";
@Component({
    templateUrl: "src/users.html"
})
export class Users implements OnInit{
    private users: Observable<User[]>;

    /*constructor(){
        let users: Array<any> = [
            {id: 1, firstName: "Bi", lastName: "Bo", userName: "BiBo"},
            {id: 2, firstName: "O", lastName: "to", userName: "Oto"}
        ];
        this.users = users;
    }*/
    constructor(private userService: UserService){ }

    private getUsers(): void {
        this.users = this.userService.getUsers();
    }

    public ngOnInit(): void{
        this.getUsers();
    }
    
}