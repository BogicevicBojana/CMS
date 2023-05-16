export class CustomHttpResponse {
  constructor(
    public data: any,
    public message: any[],
    public succeeded: boolean
  ) {}
}
