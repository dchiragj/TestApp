
import { useState } from 'react';
import './App.css';
import InputControl from './Components/InputControl';
import axios from 'axios'

function App() {
  const [formData, setFormData] = useState({
    num1: 0,
    num2: 0
  })
  const [data, setData] = useState()

  const handleInputChange = (e) => {
    const {name, value} = e.target;
    let newFormData = {
      ...formData,
      [name]: Number(value)
    }
    setFormData(newFormData)
  }

  const onSend = async() => {
    try {
      const res = await axios.post('https://localhost:7015/add', formData);
      console.log('res', res);
      if (res && res.data) {
        setData(res.data)
      }
    } catch (e) {
      console.log(e);
    } finally {

    }
  }
  return (
    <div className="App">
      <InputControl name="num1" type="number" value={formData.num1} onChange={handleInputChange} />
      <InputControl name="num2" type="number" value={formData.num2} onChange={handleInputChange} />
      <button onClick={onSend}>Send</button>
      <h4><span>Total:</span><span>{data}</span></h4>
    </div>
  );
}

export default App;
