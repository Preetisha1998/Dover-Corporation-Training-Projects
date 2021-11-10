export class AdminModel {
    Id: number;
    AdminId: string;
    Password: string;

    constructor(Id = 0,AdminId='', Password=''){
        this.Id = Id;
        this.AdminId = AdminId;
        this.Password = Password;
    }
}
