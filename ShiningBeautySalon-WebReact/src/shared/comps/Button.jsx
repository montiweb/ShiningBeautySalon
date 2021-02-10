import React, { useState } from 'react';
import enums from "../../app/core/enum";
import { Button } from 'primereact/button';

const FormButton = (props) => { 
    const classType = (type) => {
        switch (type) {
            case enums.buttontype.add:
                return 'p-button p-button-success mr-2'
                break;
            case enums.buttontype.edit:
                return  'p-button p-button-warning mr-2'
                break;
            case enums.buttontype.delete:
                return 'p-button p-button-danger mr-2'
                break; 
            case enums.buttontype.login:
                return 'p-button p-button-danger mr-2'
                break;
            case enums.buttontype.cancel:
                return 'p-button p-button-outlined p-button-secondary mr-2'
                break; 
            default:
                return 'p-button p-button-secondary'
                break;
        }
    }
    const classIcond = (type) => {
        switch (type) {
            case enums.buttontype.add:
                return 'pi pi-plus'
                break;
            case enums.buttontype.edit:
                return 'pi pi-pencil'
                break;
            case enums.buttontype.delete:
                return 'pi pi-trash'
                break;
            case enums.buttontype.login:
                return 'pi pi-sign-in'
                break;
            case enums.buttontype.cancel:
                return 'pi pi-undo'
                break; 
        } 
    }

    return <Button onClick={props.onClick} label={props.Label} className={classType(props.type)} icon={classIcond(props.type)} iconPos="right" />
}



export default FormButton;