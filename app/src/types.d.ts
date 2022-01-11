type BillType = {
    id?: number;
    billName: string;
    value: number;
    isPaid: boolean;
    finalDayPayment:string
    expectedPaymentDate?: string;
    billNumber?: number;
    totalBillNumber?: number;
  };