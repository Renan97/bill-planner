import React from "react";
import styled from "styled-components";
import EditIcon from "@mui/icons-material/Edit";

const EditPen = styled(EditIcon)`
  color: #2c2c2c;
  width: 20px;
  margin: 0 auto;
  display: block;
`;

type BillType = {
  id: number;
  billName: string;
  value: number;
  billNumber?: number;
  totalBillNumber?: number;
};
const BillDiv = styled.div`
  height: 30px;
  width: max-content;
  background-color: white;
  margin-bottom: 5px;
  text-align: left;
  padding: 5px 10px;
  border-radius: 5px;

  & > div {
    display: inline-block;
    height: 20px;
    vertical-align: middle;
    line-height: 20px;
  }
  & > div:nth-child(1) {
    width: 200px;
  }
  & > div:nth-child(2) {
    width: 100px;
    text-align: end;
  }
  & > div:nth-child(3) {
    width: 50px;
    text-align: center;
  }
  & > div:nth-child(4) {
    width: 30px;
    display: inline-flex;
    align-items: center;
  }
`;

const mockData: Array<BillType> = [
  {
    id: 1,
    billName: "Internet Vivo",
    value: 99.99,
    billNumber: undefined,
    totalBillNumber: undefined,
  },
  {
    id: 2,
    billName: "Gas cozinha",
    value: 49.99,
    billNumber: undefined,
    totalBillNumber: undefined,
  },
  {
    id: 3,
    billName: "IPVA",
    value: 149.99,
    billNumber: 2,
    totalBillNumber: 6,
  },
];

export default function BillList() {
  const Bill = ({ bill }: any) => {
    return (
      <BillDiv>
        <div>{bill.billName}</div> <div>R${bill.value}</div>{" "}
        <div>
          {bill.totalBillNumber ? (
            bill.billNumber + "/" + bill.totalBillNumber
          ) : (
            <> &infin;</>
          )}
        </div>{" "}
        <div>
          <EditPen />
        </div>
      </BillDiv>
    );
  };

  const makeEditableBill = () => {};

  return (
    <div>
      {mockData.map((bill: BillType) => (
        <Bill bill={bill} />
      ))}
    </div>
  );
}
