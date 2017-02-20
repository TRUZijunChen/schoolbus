import React from 'react';
import { Provider } from 'react-redux';
import { Router, Route, Redirect, hashHistory } from 'react-router';

import store from './store';

import Main from './views/Main.jsx';
import Home from './views/Home.jsx';
import SchoolBuses from './views/SchoolBuses.jsx';
import SchoolBusesDetail from './views/SchoolBusesDetail.jsx';
import Owners from './views/Owners.jsx';
import OwnersDetail from './views/OwnersDetail.jsx';
import Notifications from './views/Notifications.jsx';
import Users from './views/Users.jsx';
import UsersDetail from './views/UsersDetail.jsx';
import RolesPermissions from './views/RolesPermissions.jsx';
import Version from './views/Version.jsx';
import FourOhFour from './views/404.jsx';


const App = <Provider store={ store }>
  <Router history={ hashHistory }>
    <Redirect from="/" to="/home"/>
    <Route path="/" component={ Main }>
      <Route path="home" component={ Home }/>
      <Route path="school-buses" component={ SchoolBuses }/>
      <Route path="school-buses/:schoolBusId" component={ SchoolBusesDetail }/>
      <Route path="owners" component={ Owners }/>
      <Route path="owners/:ownerId" component={ OwnersDetail }/>
      <Route path="notifications" component={ Notifications }/>
      <Route path="users" component={ Users }/>
      <Route path="users/:userId" component={ UsersDetail }/>
      <Route path="roles-permissions" component={ RolesPermissions }/>
      <Route path="version" component={ Version }/>
      <Route path="*" component={ FourOhFour }/>
    </Route>
  </Router>
</Provider>;


export default App;
