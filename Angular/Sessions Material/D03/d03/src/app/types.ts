export interface Product {
  id: string;
  name: string;
  category: string;
  description?: string;
  price: number | string;
  quantity: number | string;
  imageUrl?: string;
  isInCart: boolean;
  status?: 'active' | 'inactive';
}

export type error = {
  message: string;
  state: boolean;
};
