import React, { useState } from "react";
import { Counter } from "./features/counter/Counter";
import SideMenu from "../src/features/sidemenu/SideMenu";
import "./App.css";
import styled from "styled-components";
import ListView from "./features/ListView/ListView";
const WorkArea = styled.div`
  flex: auto;
  top: 64px;
  transition: left 225ms cubic-bezier(0.4, 0, 0.6, 1) 0ms;
  position: absolute;
  padding: 5px;
`;

type pessoa = {
  nome: string;
  sobrenome: string;
  age: number;
};

function App() {
  const [open, setOpen] = useState(false);

  return (
    <div className="App">
      <SideMenu open={open} setOpen={setOpen}></SideMenu>
      <WorkArea style={open ? { left: "200px" } : { left: "57px" }}>
        <ListView></ListView>
      </WorkArea>
    </div>
  );
}

export default App;
