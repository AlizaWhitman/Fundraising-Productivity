import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MemberNewComponent } from './member-new/member-new.component';
import { MemberLoginComponent } from './member-login/member-login.component';
import { MemberDetailsComponent } from './member-details/member-details.component';
import { CallSummaryComponent } from './call-summary/call-summary.component';
import { DonorNewComponent } from './donor-new/donor-new.component';

const routes: Routes = [
  { path: '', redirectTo: 'MemberLoginComponent', pathMatch: 'full' }, 
  { path: 'MemberNewComponent', component: MemberNewComponent },
  { path: 'MemberLoginComponent', component: MemberLoginComponent },
  { path: 'MemberDetailsComponent', component: MemberDetailsComponent },
  { path: 'CallSummaryComponent', component: CallSummaryComponent },
  { path: 'DonorNewComponent', component: DonorNewComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
