import React from 'react';

const Checkbox = (props) => {
    return (
        <div className="form-group form-check font-md">
            <input type="checkbox" className="form-check-input" id={props.title} />
            <label className="form-check-label" for="exampleCheck1">{props.title}</label>
        </div>
    )

}

export default Checkbox;