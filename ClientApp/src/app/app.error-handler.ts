import {ErrorHandler, isDevMode} from '@angular/core';
import * as Sentry from '@sentry/browser';


export class AppErrorHandler implements ErrorHandler {

    /**
     *
     */
    constructor() {

    }
    handleError(error: any): void {
        if (!isDevMode()) {
        Sentry.captureException(error.originalError || error);
        } else {
        throw error;
        }
    }
}
