import { NgModule }       from '@angular/core';

import { HomeComponent } from './home.component';
import { routing } from './home.routes';
import { DevExtremeModule } from 'devextreme-angular';

@NgModule({
  imports: [routing,
    DevExtremeModule
    ],
    declarations: [HomeComponent]
})
export class HomeModule { }
