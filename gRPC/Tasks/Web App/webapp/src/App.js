import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

import { OrderServiceProtoClient } from './generated/order_grpc_web_pb';
import { CreateOrderRequest, OrderItem } from './generated/order_pb';

function App() {

  const createOrder = () => {

    const orderId = document.getElementById('orderId').value;
    const userId = document.getElementById('userId').value;
    const userName = document.getElementById('userName').value;

    const itemId = document.getElementById('itemId').value;
    const itemName = document.getElementById('itemName').value;
    const quantity = document.getElementById('quantity').value;
    const price = document.getElementById('price').value;

    const resultDiv = document.getElementById('result');

    resultDiv.innerHTML =
      '<div class="alert alert-info">Sending request...</div>';

    const client = new OrderServiceProtoClient(
      'https://localhost:7195'
    );

    const request = new CreateOrderRequest();

    request.setId(Number(orderId));
    request.setUserid(Number(userId));
    request.setUsername(userName);

    const item = new OrderItem();

    item.setId(Number(itemId));
    item.setName(itemName);
    item.setQuantity(Number(quantity));
    item.setPrice(Number(price));

    request.addItems(item);

    client.createOrder(request, {}, (err, response) => {

      if (err) {
        resultDiv.innerHTML = `
          <div class="alert alert-danger">
            <strong>Error:</strong> ${err.message}
          </div>
        `;
        return;
      }

      const data = response.toObject();

      console.log('Order Created:', data);

      if (data.success) {
        resultDiv.innerHTML = `
        <div class="alert alert-success">
          <h5>Order Created Successfully</h5>
          <hr/>
          <pre>${JSON.stringify(data, null, 2)}</pre>
        </div>
      `;
      } else {
        resultDiv.innerHTML = `
          <div class="alert alert-warning">
            <h5>Order Creation Failed</h5>
            <hr/>
            <pre>${JSON.stringify(data, null, 2)}</pre>
          </div>
        `;
      }
    });
  };

  return (
    <div className="container mt-5">

      <div className="card shadow">

        <div className="card-header">
          <h2>Create Order (gRPC-Web)</h2>
        </div>

        <div className="card-body">

          <div className="row">

            <div className="col-md-4 mb-3">
              <label className="form-label">Order Id</label>
              <input
                id="orderId"
                type="number"
                className="form-control"
                defaultValue="1"
              />
            </div>

            <div className="col-md-4 mb-3">
              <label className="form-label">User Id</label>
              <input
                id="userId"
                type="number"
                className="form-control"
                defaultValue="1"
              />
            </div>

            <div className="col-md-4 mb-3">
              <label className="form-label">User Name</label>
              <input
                id="userName"
                type="text"
                className="form-control"
                defaultValue="Youssef"
              />
            </div>

          </div>

          <hr />

          <h4>Item Information</h4>

          <div className="row">

            <div className="col-md-3 mb-3">
              <label className="form-label">Item Id</label>
              <input
                id="itemId"
                type="number"
                className="form-control"
                defaultValue="1"
              />
            </div>

            <div className="col-md-3 mb-3">
              <label className="form-label">Item Name</label>
              <input
                id="itemName"
                type="text"
                className="form-control"
                defaultValue="Pizza"
              />
            </div>

            <div className="col-md-3 mb-3">
              <label className="form-label">Quantity</label>
              <input
                id="quantity"
                type="number"
                className="form-control"
                defaultValue="1"
              />
            </div>

            <div className="col-md-3 mb-3">
              <label className="form-label">Price</label>
              <input
                id="price"
                type="number"
                className="form-control"
                defaultValue="100"
              />
            </div>

          </div>

          <button
            className="btn btn-primary btn-lg"
            onClick={createOrder}
          >
            Create Order
          </button>

          <div id="result" className="mt-4"></div>

        </div>

      </div>

    </div>
  );
}

export default App;