import React from 'react';
import FormButton from './Button';

const OperationButton = (props) => {

    return <>
        {
            (props.list && props.list.length > 0) ? 
                props.list.map((item, index) => {
                    return <FormButton key={index} label={item.label} onClick={item.onClick} type={item.type}/>
                }) : <></>
        }

    </>

}

export default OperationButton;