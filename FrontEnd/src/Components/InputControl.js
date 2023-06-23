import React from 'react'

const InputControl = ({name, type, pattern, value, onChange}) => {
  return (
    <>
    <input name={name} type={type} pattern={pattern} value={value} onChange={onChange} />
    </>
  )
}

export default InputControl