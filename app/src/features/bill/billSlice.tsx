import { createSlice, PayloadAction } from "@reduxjs/toolkit";
import { RootState } from "../../app/store";

const initialState: Array<BillType> = [
  {
    id: 1,
    billName: "Internet Vivo",
    value: 99.99,
    isPaid: true,
    finalDayPayment: "20/01/2022",
    expectedPaymentDate: "10/01/2022",
    billNumber: undefined,
    totalBillNumber: undefined,
  },
];

export const billSlice = createSlice({
  name: "bill",
  initialState,
  reducers: {
    addBill: (state, action: PayloadAction<BillType>) => {
      state.push(action.payload);
    },
  },
});

export const { addBill } = billSlice.actions;
export const billSelector = (state: RootState) => state;
export default billSlice.reducer;
