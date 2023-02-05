import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { RouterModule } from '@angular/router';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MatTableModule } from '@angular/material/table';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button'
import { MatNativeDateModule } from '@angular/material/core';
import { MaterialExampleModule } from '../material.module'
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { VechicalComponent } from './vechical/vechical.component';
import { GarageComponent } from './Pages/garage/garage.component';
import { DailyworkComponent } from './dailywork/dailywork.component';
import { MaintanancesummaryComponent } from './maintanancesummary/maintanancesummary.component';
import { AddOrUpdataVehicleComponent } from './vechical/add-or-updata-vehicle/add-or-updata-vehicle.component';



@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    DashboardComponent,
    VechicalComponent,
    GarageComponent,
    DailyworkComponent,
    MaintanancesummaryComponent,
    AddOrUpdataVehicleComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatButtonModule,
    MatNativeDateModule,
    MaterialExampleModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    MatTableModule,
    RouterModule.forRoot([
      { path: "", pathMatch: "full", redirectTo: '/login' },
      { path: 'login', component: LoginComponent },
      { path: 'register', component: RegisterComponent },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'vechical', component: VechicalComponent },
      { path: 'garage', component: GarageComponent },
      { path: 'dailywork', component: DailyworkComponent },
      { path: 'maintanancesummary', component: MaintanancesummaryComponent }
    ])
  ],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA,
    NO_ERRORS_SCHEMA
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
