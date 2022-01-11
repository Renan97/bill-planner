import React from "react";
import styled from "styled-components";
import EditIcon from "@mui/icons-material/Edit";
import { useAppSelector, useAppDispatch } from "../../app/hooks";
import { billSelector } from "../bill/billSlice";

const EditPen = styled(EditIcon)`
  color: #2c2c2c;
  width: 20px;
  margin: 0 auto;
  display: block;
`;

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
  & > div:nth-child(2) {
    width: 200px;
  }
  & div:nth-child(3) {
    width: 100px;
    text-align: end;
  }
  & div:nth-child(4) {
    width: 50px;
    text-align: center;
  }
  & div:nth-child(5) {
    width: 90px;
    text-align: center;
  }
  & div:nth-child(6) {
    width: 90px;
    text-align: center;
  }
  & div:nth-child(7) {
    width: 30px;
    display: inline-flex;
    align-items: center;
  }
`;
const IsPaidInput = styled.input`
  position: relative;
  position: relative;
  top: 4px;
  left: 0;
`;

export default function BillList() {
  const billList = useAppSelector(billSelector).bill;
  const dispatch = useAppDispatch();
  const Bill = (bill: BillType) => {
    return (
      <BillDiv>
        <IsPaidInput
          checked={bill.isPaid}
          type="checkbox"
          name="isPaid"
          id="input-paid"
        />
        <div style={{ textDecoration: bill.isPaid ? "line-through" : "" }}>
          {bill.billName}
        </div>{" "}
        <div>R${bill.value}</div>
        <div>
          {bill.totalBillNumber ? (
            bill.billNumber + "/" + bill.totalBillNumber
          ) : (
            <> &infin;</>
          )}
        </div>
        <div>{bill.expectedPaymentDate}</div>
        <div>{bill.finalDayPayment}</div>
        <div>
          <EditPen />
        </div>
      </BillDiv>
    );
  };

  return <div>{billList.map((bill: BillType) => Bill(bill))}</div>;
}
