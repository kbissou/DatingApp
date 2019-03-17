import { Resolve, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Injectable } from '@angular/core';
import { User } from '../_models/user';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';

@Injectable()
export class MemberListRsolver implements Resolve<User[]>{
    constructor(private userService: UserService, private route: Router,
        private alertify: AlertifyService){}

        resolve(route: ActivatedRouteSnapshot):  Observable<User[]>  {
            return this.userService.getUsers().pipe(
                catchError(error => {
                    this.alertify.error('problem retriving data');
                    this.route.navigate(['/home']);
                    return of(null);
                })
                );
        }

}