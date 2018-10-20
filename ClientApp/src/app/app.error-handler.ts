import {ErrorHandler} from '@angular/core';
import * as Sentry from '@sentry/browser';


export class AppErrorHandler implements ErrorHandler {

    /**
     *
     */
    constructor() {

    }
    handleError(error: any): void {
        Sentry.captureException(error.originalError || error);
    }
}
