export interface KeyValuePair {
    id: number;
    name: string;
}

export interface Contact {
    name: string;
    phone: string;
    email: string;
}

export interface Vehicle {
    id: number;
    model: KeyValuePair;
    make: KeyValuePair;
    is_registered: boolean;
    features: KeyValuePair[];
    contact: Contact;
    last_update: string;
}
export interface SaveVehicle {
    id: number;
    modelid: number;
    makeid: number;
    is_registered: boolean;
    features: number[];
    contact: Contact;
}
