import React, { useState } from "react";
import Modal from "@mui/material/Modal";
import styled from "styled-components";
import { addBill, billSelector } from "../bill/billSlice";
import { useAppSelector, useAppDispatch } from "../../app/hooks";

type AddBillModalType = {
  openModal: boolean;
  setOpenModal: React.Dispatch<React.SetStateAction<boolean>>;
};
const initialState: BillType = {
  id: 0,
  billName: "",
  value: 0,
  isPaid: false,
  finalDayPayment: "",
  expectedPaymentDate: "",
  billNumber: undefined,
  totalBillNumber: undefined,
};

const ModalContainer = styled.div`
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 400px;
  background-color: beige;
  border: "2px solid #000";
  box-shadow: 24;
  border-radius: 5px;
`;
const HeaderModal = styled.div`
  height: 30px;
  line-height: 30px;
  padding: 0 5px;
  & span:nth-child(2) {
    float: right;
  }
`;
const ModalBody = styled.div``;
const ModalFooter = styled.div`
  height: 20px;
  padding: 5px 5px;
  & button {
    border: 1px solid blue;
    border-radius: 3px;
    display: inline-block;
  }
  & button:nth-child(1) {
    float: left;
  }
  & button:nth-child(2) {
    float: right;
  }
`;

export default function AddBillModal({
  openModal,
  setOpenModal,
}: AddBillModalType) {
  const handleClose = () => setOpenModal(false);
  const dispatch = useAppDispatch();
  const [createBill, setCreateBill] = useState<BillType>(initialState);

  const handleChange = (event: any) => {
    // let state = { ...createBill };
    // state[event.target.id] = event.target.value;
    // setCreateBill(state);

    setCreateBill({
      ...createBill,
      [event.target.id]: event.target.value as any,
    });
  };
  const handleSave = () => {
    dispatch(addBill(createBill));
    handleClose();
    setCreateBill(initialState);
  };
  return (
    <Modal
      open={openModal}
      onClose={handleClose}
      aria-labelledby="modal-modal-title"
      aria-describedby="modal-modal-description"
    >
      <ModalContainer>
        <HeaderModal>
          <span>Add bill to the list</span>
          <span onClick={handleClose}>X</span>
        </HeaderModal>
        <ModalBody>
          <label htmlFor="billName">
            Bill name
            <input
              onChange={handleChange}
              value={createBill?.billName}
              required
              id={"billName"}
              type="text"
            />
          </label>
          <br />
          <label htmlFor="value">
            Bill value
            <input
              onChange={handleChange}
              value={createBill?.value}
              required
              id={"value"}
              type="number"
            />
          </label>
          <br />
          <label htmlFor="totalBillNumber">
            Bill total installments
            <input
              onChange={handleChange}
              value={createBill?.totalBillNumber}
              id={"totalBillNumber"}
              type="number"
            />
          </label>
          <br />
          <label htmlFor="billNumber">
            Current installment
            <input
              onChange={handleChange}
              value={createBill?.billNumber}
              id={"billNumber"}
              type="number"
            />
          </label>
          <br />
          <label htmlFor="finalDayPayment">
            Final payment date
            <input
              onChange={handleChange}
              value={createBill?.finalDayPayment}
              required
              id={"finalDayPayment"}
              type="date"
            />
          </label>
          <br />
          <label htmlFor="expectedPaymentDate">
            Expected payment date
            <input
              onChange={handleChange}
              value={createBill?.expectedPaymentDate}
              id={"expectedPaymentDate"}
              type="date"
            />
          </label>
          <br />
        </ModalBody>
        <ModalFooter>
          <button onClick={handleClose}>Cancel</button>
          <button onClick={handleSave}>Save</button>
        </ModalFooter>
      </ModalContainer>
    </Modal>
  );
}
