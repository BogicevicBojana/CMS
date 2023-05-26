export class RegisterUserDTO {
  constructor(
    public first_name: string,
    public last_name: string,
    public email: string,
    public employment_date: Date,
    public working_position_id: Number | null,
    public role_id: Number | null
  ) {}
}
