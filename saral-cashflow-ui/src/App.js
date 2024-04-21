import { BrowserRouter, Route, Routes } from "react-router-dom";
import Home from "./components/Home";
import Master from "./components/Master";
import "./App.css";
import NavBar from "./components/NavBar";
import Alert from "./components/alerts/alert";
import AppContext from "./components/contexts/AppContext";
import { showFadingAlert } from "./components/methods/utils";
import Login from "./components/Login";

function App() {
  return <Login/>
  // return (
  //   <AppContext.Provider value={{ showFadingAlert: showFadingAlert }}>
  //     <BrowserRouter>
  //       <NavBar />
  //       <Alert />
  //       <Routes>
  //         <Route exact path="/" element={<Home />}></Route>
  //         <Route exact path="/Master" element={<Master />}></Route>
  //       </Routes>
  //     </BrowserRouter>
  //   </AppContext.Provider>
  // );
}

export default App;
